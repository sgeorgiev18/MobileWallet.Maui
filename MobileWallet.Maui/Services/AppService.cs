using MobileWallet.Maui.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Services
{
    public class AppService : IAppService
    {
        public async Task<LoginResponse> Authenticate(LoginModel loginModel)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
            using var client = new HttpClient(handler);
            var url = $"{Settings.BaseUrl}{APIs.AuthenticateUser}";


            var serializedStr = JsonConvert.SerializeObject(loginModel);

            var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

            try
            {
                string contentStr = await response.Content.ReadAsStringAsync();
                var returnResponse = JsonConvert.DeserializeObject<LoginResponse>(contentStr);

                if (returnResponse.Success)
                {
                    Settings.UserBasicDetail = new UserBasicDetail(returnResponse.UserGuid, returnResponse.Token, loginModel.Email, true, 0);
                }

                return returnResponse;
            }
            catch (Exception ex)
            {
                return new LoginResponse()
                {
                    Success = false,
                    ErrorMessage = ex.Message,
                    UserGuid = Guid.Empty,
                    Token = Guid.Empty
                };
            }
        }

        public async Task<RegisterResponse> Register(RegisterModel registerModel)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };

            using var client = new HttpClient(handler);
            var url = $"{Settings.BaseUrl}{APIs.RegisterUser}";

            var serializedStr = JsonConvert.SerializeObject(registerModel);

            try
            {
                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));
                string contentStr = await response.Content.ReadAsStringAsync();
                var returnResponse = JsonConvert.DeserializeObject<RegisterResponse>(contentStr);
                return returnResponse;
            }
            catch(Exception ex) 
            {
                return new RegisterResponse() 
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
            
        }

        public async Task<CreateToken2UserResponse> CreateToken(CreateToken2UserReq req)
        {
            HttpClientHandler handler = new();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };

            using var client = new HttpClient(handler);
            var url = $"{Settings.BaseUrl}{APIs.CreateToken}";

            var serializedStr = JsonConvert.SerializeObject(req);

            try
            {
                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));
                string contentStr = await response.Content.ReadAsStringAsync();
                var returnResponse = JsonConvert.DeserializeObject<CreateToken2UserResponse>(contentStr);

                return returnResponse;
            }
            catch (Exception ex)
            {
                return new CreateToken2UserResponse()
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<RefreshToken2UserResponse> RefreshToken(RefreshToken2UserReq req)
        {
            HttpClientHandler handler = new();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };

            using var client = new HttpClient(handler);
            var url = $"{Settings.BaseUrl}{APIs.RefreshToken}";

            var serializedStr = JsonConvert.SerializeObject(req);

            try
            {
                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));
                string contentStr = await response.Content.ReadAsStringAsync();
                var returnResponse = JsonConvert.DeserializeObject<RefreshToken2UserResponse>(contentStr);

                return returnResponse;
            }
            catch (Exception ex)
            {
                return new RefreshToken2UserResponse()
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<CheckToken2UserResponse> CheckToken(CheckToken2UserReq req)
        {
            HttpClientHandler handler = new();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };

            using var client = new HttpClient(handler);
            var url = $"{Settings.BaseUrl}{APIs.CheckToken}";

            var serializedStr = JsonConvert.SerializeObject(req);

            try
            {
                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));
                string contentStr = await response.Content.ReadAsStringAsync();
                var returnResponse = JsonConvert.DeserializeObject<CheckToken2UserResponse>(contentStr);

                return returnResponse;
            }
            catch (Exception ex)
            {
                return new CheckToken2UserResponse()
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
