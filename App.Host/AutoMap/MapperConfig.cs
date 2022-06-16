using AutoMapper;

namespace AppHost.AutoMap
{
    public class MapperConfig
    {
        public static MapperConfiguration GetConfiguration()
        {
            var configExpression = new MapperConfigurationExpression();

            configExpression.AddProfile<DetailProfile>();
            configExpression.AddProfile<EmployeeProfile>();

            var config = new MapperConfiguration(configExpression);
            config.AssertConfigurationIsValid();

            return config;
        }
    }
}