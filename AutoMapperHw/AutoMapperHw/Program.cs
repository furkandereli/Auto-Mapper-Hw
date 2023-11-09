//AutoMapper veri nesneleri arasında otomatik olarak eşleme işlemi yapmaya yardımcı bir kütüphanedir.
//Genellikle veritabanı nesneleri ile iş mantığı nesneleri arasında veri taşıma işlemlerini kolaylaştırmak için kullanılır.
//Otomatik eşleme yaparak veri taşıma işlemini daha az tekrarlayıcı ve hata yapma olasılığını azaltarak gerçekleştirir.
//Kod fazlalığından bizi kurtarır.
//Package Managerdan "Install-Package AutoMapper" kodu çalıştırılarak projeye entegre edilebilir.

using AutoMapper;
using AutoMapperHw.Mapping.AutoMapperProfile;
using AutoMapperHw.Models;

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});

IMapper mapper = config.CreateMapper();

Person person = new Person()
{
    Id = 1,
    Age = 25,
    Name = "Furkan",
    Surname = "Dereli"
};

PersonDTO personDTO = mapper.Map<PersonDTO>(person);

Console.WriteLine(personDTO.ToString());