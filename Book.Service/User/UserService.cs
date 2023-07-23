using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Book.Access.Repository.Abstract;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Book.Service.User;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly AppSettings _appSettings;

    public UserService(IOptions<AppSettings> appSettings, IUserRepository userRepository)
    {
        _appSettings = appSettings.Value;
        _userRepository = userRepository;
    }

    public Data.Entities.User Authenticate(string name, string password)
    {
        var user = _userRepository.SingleOrDefaultAsync(x => x.Name == name && x.Password == password).Result;

        // Kullanici bulunamadıysa null döner.
        if (user == null)
            return null;

        // Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[] 
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        user.Token = tokenHandler.WriteToken(token);

        // Sifre null olarak gonderilir.
        user.Password = null;
        return user;
    }

}