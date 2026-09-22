
namespace ConsoleApp2
{
    public class CompanyConfiguration : EntityTemlateConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);

            builder.OwnsOne(company => company.Address, AddressConfiguration.Configure);
        }
    }
}