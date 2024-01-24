using AutoMapper;

namespace apivendas.Data.Map.Automapper
{
    public static class MapperFactory
    {
        static Mapper? _mapper;

        static List<Profile?>? _profiles { get; set; }

        public static Mapper Mapper { get { return _mapper ?? throw new Exception("Mapper Not Initialized"); } }

        public static void Setup()
        {
            _profiles = _profiles ?? new List<Profile?>();

            _profiles.Add(new ServicoParaDtos());

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;
                foreach (var profile in _profiles)
                {
                    try
                    {
                        cfg.AddProfile(profile);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
            });

            _mapper = new Mapper(config);
        }
    }
}