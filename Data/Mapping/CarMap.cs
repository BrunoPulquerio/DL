using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class CarMap
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Brand)
                .HasColumnName("Marca")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(prop => prop.Model)
                .HasColumnName("Modelo")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(prop => prop.Version)
                .HasColumnName("Versão")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(prop => prop.Placa)
                .HasColumnName("Placa")
                .HasColumnType("varchar(7)")
                .IsRequired();

            builder.Property(prop => prop.Renavam)
                .HasColumnName("Renavam")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(prop => prop.Chassi)
                .HasColumnName("Chassi")
                .HasColumnType("varchar(17)")
                .IsRequired();
        }
    }
}