using AM.infrastructure.Responsitory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure.Service.Model
{
    public class ProductModel15
    {

        public ProductModel15()
        {

        }

        public ProductModel15(ProductDto15 dto)
        {
            ProductId = dto.ProductId;
            ProductName = dto.ProductName;
            Price = dto.Price;
            CreatedDate = dto.CreatedDate;
            DateManufactory = dto.DateManufactory;
            DateExpried = dto.DateExpried;
            Properties1 = dto.Properties1;
            Properties2 = dto.Properties2;
            Properties3 = dto.Properties3;
            Properties4 = dto.Properties4;
            Properties5 = dto.Properties5;
            Properties6 = dto.Properties6;
            Properties7 = dto.Properties7;
            Properties8 = dto.Properties8;
            Properties9 = dto.Properties9;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateManufactory { get; set; }
        public DateTime DateExpried { get; set; }

        public long Properties1 { get; set; }
        public long Properties2 { get; set; }
        public long Properties3 { get; set; }
        public long Properties4 { get; set; }
        public long Properties5 { get; set; }
        public long Properties6 { get; set; }
        public long Properties7 { get; set; }
        public long Properties8 { get; set; }
        public long Properties9 { get; set; }

        public string Link
        {
            get
            {
                return string.Format("/{0}-pid{1}", ProductName, ProductId);
            }
        }

        public string CreatedDateFormat { 
            get {
                return CreatedDate.ToString("dd/MM/YYYY");
            } 
        }
    }

    public class ProductModel50
    {
        public ProductModel50()
        {

        }
        public ProductModel50(ProductDto50 dto)
        {
            Id = dto.ProductId;
            ProductName = dto.ProductName;
            Price = dto.Price;
            CreatedDate = dto.CreatedDate;
            DateManufactory = dto.DateManufactory;
            DateExpried = dto.DateExpried;
            Properties1 = dto.Properties1;
            Properties2 = dto.Properties2;
            Properties3 = dto.Properties3;
            Properties4 = dto.Properties4;
            Properties5 = dto.Properties5;
            Properties6 = dto.Properties6;
            Properties7 = dto.Properties7;
            Properties8 = dto.Properties8;
            Properties9 = dto.Properties9;
            Properties10 = dto.Properties10;
            Properties11 = dto.Properties11;
            Properties12 = dto.Properties12;
            Properties13 = dto.Properties13;
            Properties14 = dto.Properties14;
            Properties15 = dto.Properties15;
            Properties16 = dto.Properties16;
            Properties17 = dto.Properties17;
            Properties18 = dto.Properties18;
            Properties19 = dto.Properties19;
            Properties20 = dto.Properties20;
            Properties21 = dto.Properties21;
            Properties22 = dto.Properties22;
            Properties23 = dto.Properties23;
            Properties24 = dto.Properties24;
            Properties25 = dto.Properties25;
            Properties26 = dto.Properties26;
            Properties27 = dto.Properties27;
            Properties28 = dto.Properties28;
            Properties29 = dto.Properties29;
            Properties30 = dto.Properties30;
            Properties31 = dto.Properties31;
            Properties32 = dto.Properties32;
            Properties33 = dto.Properties33;
            Properties34 = dto.Properties34;
            Properties35 = dto.Properties35;
            Properties36 = dto.Properties36;
            Properties37 = dto.Properties37;
            Properties38 = dto.Properties38;
            Properties39 = dto.Properties39;
            Properties40 = dto.Properties40;
            Properties41 = dto.Properties41;
            Properties42 = dto.Properties42;
        }


        public int Id { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateManufactory { get; set; }
        public DateTime DateExpried { get; set; }

        public long Properties1 { get; set; }
        public long Properties2 { get; set; }
        public long Properties3 { get; set; }
        public long Properties4 { get; set; }
        public long Properties5 { get; set; }
        public long Properties6 { get; set; }
        public long Properties7 { get; set; }
        public long Properties8 { get; set; }
        public long Properties9 { get; set; }
        public long Properties10 { get; set; }
        public long Properties11 { get; set; }
        public long Properties12 { get; set; }
        public long Properties13 { get; set; }
        public long Properties14 { get; set; }
        public long Properties15 { get; set; }
        public long Properties16 { get; set; }
        public long Properties17 { get; set; }
        public long Properties18 { get; set; }
        public long Properties19 { get; set; }
        public long Properties20 { get; set; }
        public long Properties21 { get; set; }
        public long Properties22 { get; set; }
        public long Properties23 { get; set; }
        public long Properties24 { get; set; }
        public long Properties25 { get; set; }
        public long Properties26 { get; set; }
        public long Properties27 { get; set; }
        public long Properties28 { get; set; }
        public long Properties29 { get; set; }
        public long Properties30 { get; set; }
        public long Properties31 { get; set; }
        public long Properties32 { get; set; }
        public long Properties33 { get; set; }
        public long Properties34 { get; set; }
        public long Properties35 { get; set; }
        public long Properties36 { get; set; }
        public long Properties37 { get; set; }
        public long Properties38 { get; set; }
        public long Properties39 { get; set; }
        public long Properties40 { get; set; }
        public long Properties41 { get; set; }
        public long Properties42 { get; set; }
        public long Properties43 { get; set; }
        public long Properties44 { get; set; }

        public string Link
        {
            get
            {
                return string.Format("/{0}-pid{1}", ProductName, Id);
            }
        }

        public string CreatedDateFormat
        {
            get
            {
                return CreatedDate.ToString("dd/MM/YYYY");
            }
        }
    }


    public class ProductModelComplex15
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float ProductPrice { get; set; }
        public DateTime CreatedDateModel { get; set; }
        public DateTime DateManufactoryModel { get; set; }
        public DateTime DateExpriedModel { get; set; }

        public long ModelProperties1 { get; set; }
        public long ModelProperties2 { get; set; }
        public long ModelProperties3 { get; set; }
        public long ModelProperties4 { get; set; }
        public long ModelProperties5 { get; set; }
        public long ModelProperties6 { get; set; }
        public long ModelProperties7 { get; set; }
        public long ModelProperties8 { get; set; }
        public long ModelProperties9 { get; set; }

        public string Link
        {
            get
            {
                return string.Format("/{0}-pid{1}", Name, Id);
            }
        }

        public string CreatedDateFormat
        {
            get
            {
                return CreatedDateModel.ToString("dd/MM/YYYY");
            }
        }
    }

    public class ProductModelComplex50
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float ProductPrice { get; set; }
        public DateTime CreatedDateModel { get; set; }
        public DateTime DateManufactoryModel { get; set; }
        public DateTime DateExpriedModel { get; set; }

        public long ModelProperties1 { get; set; }
        public long ModelProperties2 { get; set; }
        public long ModelProperties3 { get; set; }
        public long ModelProperties4 { get; set; }
        public long ModelProperties5 { get; set; }
        public long ModelProperties6 { get; set; }
        public long ModelProperties7 { get; set; }
        public long ModelProperties8 { get; set; }
        public long ModelProperties9 { get; set; }
        public long ModelProperties10 { get; set; }
        public long ModelProperties11 { get; set; }
        public long ModelProperties12 { get; set; }
        public long ModelProperties13 { get; set; }
        public long ModelProperties14 { get; set; }
        public long ModelProperties15 { get; set; }
        public long ModelProperties16 { get; set; }
        public long ModelProperties17 { get; set; }
        public long ModelProperties18 { get; set; }
        public long ModelProperties19 { get; set; }
        public long ModelProperties20 { get; set; }
        public long ModelProperties21 { get; set; }
        public long ModelProperties22 { get; set; }
        public long ModelProperties23 { get; set; }
        public long ModelProperties24 { get; set; }
        public long ModelProperties25 { get; set; }
        public long ModelProperties26 { get; set; }
        public long ModelProperties27 { get; set; }
        public long ModelProperties28 { get; set; }
        public long ModelProperties29 { get; set; }
        public long ModelProperties30 { get; set; }
        public long ModelProperties31 { get; set; }
        public long ModelProperties32 { get; set; }
        public long ModelProperties33 { get; set; }
        public long ModelProperties34 { get; set; }
        public long ModelProperties35 { get; set; }
        public long ModelProperties36 { get; set; }
        public long ModelProperties37 { get; set; }
        public long ModelProperties38 { get; set; }
        public long ModelProperties39 { get; set; }
        public long ModelProperties40 { get; set; }
        public long ModelProperties41 { get; set; }
        public long ModelProperties42 { get; set; }
        public long ModelProperties43 { get; set; }
        public long ModelProperties44 { get; set; }

        public string Link
        {
            get
            {
                return string.Format("/{0}-pid{1}", Name, Id);
            }
        }

        public string CreatedDateFormat
        {
            get
            {
                return CreatedDateModel.ToString("dd/MM/YYYY");
            }
        }
    }
}
