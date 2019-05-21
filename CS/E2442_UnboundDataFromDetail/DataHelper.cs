using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2442_UnboundDataFromDetail
{
    class DataHelper
    {
        public static DataTable CreateCategoriesTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;
            table.Columns.Add("CategoryID", typeof(System.Int32));
            table.Columns.Add("CategoryName", typeof(System.String));
            table.Columns.Add("Description", typeof(System.String));
            dataRow = table.NewRow();
            dataRow["CategoryID"] = 1;
            dataRow["CategoryName"] = "Beverages";
            dataRow["Description"] = "Soft drinks, coffees, teas, beers, and ales";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 2;
            dataRow["CategoryName"] = "Condiments";
            dataRow["Description"] = "Sweet and savory sauces, relishes, spreads, and seasonings";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 3;
            dataRow["CategoryName"] = "Confections";
            dataRow["Description"] = "Desserts, candies, and sweet breads";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 4;
            dataRow["CategoryName"] = "Dairy Products";
            dataRow["Description"] = "Cheeses";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 5;
            dataRow["CategoryName"] = "Grains/Cereals";
            dataRow["Description"] = "Breads, crackers, pasta, and cereal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 6;
            dataRow["CategoryName"] = "Meat/Poultry";
            dataRow["Description"] = "Prepared meats";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 7;
            dataRow["CategoryName"] = "Produce";
            dataRow["Description"] = "Dried fruit and bean curd";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["CategoryID"] = 8;
            dataRow["CategoryName"] = "Seafood";
            dataRow["Description"] = "Seaweed and fish";
            table.Rows.Add(dataRow);

            return table;
        }

        public static DataTable CreateProductsTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;
            table.Columns.Add("ProductID", typeof(System.Int32));
            table.Columns.Add("ProductName", typeof(System.String));
            table.Columns.Add("CategoryID", typeof(System.Int32));
            table.Columns.Add("QuantityPerUnit", typeof(System.String));
            table.Columns.Add("UnitPrice", typeof(System.Decimal));
            table.Columns.Add("UnitsInStock", typeof(System.Int16));
            dataRow = table.NewRow();
            dataRow["ProductID"] = 1;
            dataRow["ProductName"] = "Chai";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "10 boxes x 20 bags";
            dataRow["UnitPrice"] = 18;
            dataRow["UnitsInStock"] = 39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 2;
            dataRow["ProductName"] = "Chang";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 12 oz bottles";
            dataRow["UnitPrice"] = 19;
            dataRow["UnitsInStock"] = 17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 3;
            dataRow["ProductName"] = "Aniseed Syrup";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "12 - 550 ml bottles";
            dataRow["UnitPrice"] = 10;
            dataRow["UnitsInStock"] = 13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 4;
            dataRow["ProductName"] = "Chef Anton's Cajun Seasoning";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "48 - 6 oz jars";
            dataRow["UnitPrice"] = 22;
            dataRow["UnitsInStock"] = 53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 5;
            dataRow["ProductName"] = "Chef Anton's Gumbo Mix";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "36 boxes";
            dataRow["UnitPrice"] = 21.35;
            dataRow["UnitsInStock"] = 0;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 6;
            dataRow["ProductName"] = "Grandma's Boysenberry Spread";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "12 - 8 oz jars";
            dataRow["UnitPrice"] = 25;
            dataRow["UnitsInStock"] = 120;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 7;
            dataRow["ProductName"] = "Uncle Bob's Organic Dried Pears";
            dataRow["CategoryID"] = 7;
            dataRow["QuantityPerUnit"] = "12 - 1 lb pkgs.";
            dataRow["UnitPrice"] = 30;
            dataRow["UnitsInStock"] = 15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 8;
            dataRow["ProductName"] = "Northwoods Cranberry Sauce";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "12 - 12 oz jars";
            dataRow["UnitPrice"] = 40;
            dataRow["UnitsInStock"] = 6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 9;
            dataRow["ProductName"] = "Mishi Kobe Niku";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "18 - 500 g pkgs.";
            dataRow["UnitPrice"] = 97;
            dataRow["UnitsInStock"] = 29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 10;
            dataRow["ProductName"] = "Ikura";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "12 - 200 ml jars";
            dataRow["UnitPrice"] = 31;
            dataRow["UnitsInStock"] = 31;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 11;
            dataRow["ProductName"] = "Queso Cabrales";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "1 kg pkg.";
            dataRow["UnitPrice"] = 21;
            dataRow["UnitsInStock"] = 22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 12;
            dataRow["ProductName"] = "Queso Manchego La Pastora";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "10 - 500 g pkgs.";
            dataRow["UnitPrice"] = 38;
            dataRow["UnitsInStock"] = 86;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 13;
            dataRow["ProductName"] = "Konbu";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "2 kg box";
            dataRow["UnitPrice"] = 6;
            dataRow["UnitsInStock"] = 24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 14;
            dataRow["ProductName"] = "Tofu";
            dataRow["CategoryID"] = 7;
            dataRow["QuantityPerUnit"] = "40 - 100 g pkgs.";
            dataRow["UnitPrice"] = 23.25;
            dataRow["UnitsInStock"] = 35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 15;
            dataRow["ProductName"] = "Genen Shouyu";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "24 - 250 ml bottles";
            dataRow["UnitPrice"] = 15.5;
            dataRow["UnitsInStock"] = 39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 16;
            dataRow["ProductName"] = "Pavlova";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "32 - 500 g boxes";
            dataRow["UnitPrice"] = 17.45;
            dataRow["UnitsInStock"] = 29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 17;
            dataRow["ProductName"] = "Alice Mutton";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "20 - 1 kg tins";
            dataRow["UnitPrice"] = 39;
            dataRow["UnitsInStock"] = 0;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 18;
            dataRow["ProductName"] = "Carnarvon Tigers";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "16 kg pkg.";
            dataRow["UnitPrice"] = 62.5;
            dataRow["UnitsInStock"] = 42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 19;
            dataRow["ProductName"] = "Teatime Chocolate Biscuits";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "10 boxes x 12 pieces";
            dataRow["UnitPrice"] = 9.2;
            dataRow["UnitsInStock"] = 25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 20;
            dataRow["ProductName"] = "Sir Rodney's Marmalade";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "30 gift boxes";
            dataRow["UnitPrice"] = 81;
            dataRow["UnitsInStock"] = 40;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 21;
            dataRow["ProductName"] = "Sir Rodney's Scones";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "24 pkgs. x 4 pieces";
            dataRow["UnitPrice"] = 10;
            dataRow["UnitsInStock"] = 3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 22;
            dataRow["ProductName"] = "Gustaf's Knäckebröd";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "24 - 500 g pkgs.";
            dataRow["UnitPrice"] = 21;
            dataRow["UnitsInStock"] = 104;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 23;
            dataRow["ProductName"] = "Tunnbröd";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "12 - 250 g pkgs.";
            dataRow["UnitPrice"] = 9;
            dataRow["UnitsInStock"] = 61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 24;
            dataRow["ProductName"] = "Guaraná Fantástica";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "12 - 355 ml cans";
            dataRow["UnitPrice"] = 4.5;
            dataRow["UnitsInStock"] = 20;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 25;
            dataRow["ProductName"] = "NuNuCa Nuß-Nougat-Creme";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "20 - 450 g glasses";
            dataRow["UnitPrice"] = 14;
            dataRow["UnitsInStock"] = 76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 26;
            dataRow["ProductName"] = "Gumbär Gummibärchen";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "100 - 250 g bags";
            dataRow["UnitPrice"] = 31.23;
            dataRow["UnitsInStock"] = 15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 27;
            dataRow["ProductName"] = "Schoggi Schokolade";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "100 - 100 g pieces";
            dataRow["UnitPrice"] = 43.9;
            dataRow["UnitsInStock"] = 49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 28;
            dataRow["ProductName"] = "Rössle Sauerkraut";
            dataRow["CategoryID"] = 7;
            dataRow["QuantityPerUnit"] = "25 - 825 g cans";
            dataRow["UnitPrice"] = 45.6;
            dataRow["UnitsInStock"] = 26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 29;
            dataRow["ProductName"] = "Thüringer Rostbratwurst";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "50 bags x 30 sausgs.";
            dataRow["UnitPrice"] = 123.79;
            dataRow["UnitsInStock"] = 0;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 30;
            dataRow["ProductName"] = "Nord-Ost Matjeshering";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "10 - 200 g glasses";
            dataRow["UnitPrice"] = 25.89;
            dataRow["UnitsInStock"] = 10;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 31;
            dataRow["ProductName"] = "Gorgonzola Telino";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "12 - 100 g pkgs";
            dataRow["UnitPrice"] = 12.5;
            dataRow["UnitsInStock"] = 0;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 32;
            dataRow["ProductName"] = "Mascarpone Fabioli";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "24 - 200 g pkgs.";
            dataRow["UnitPrice"] = 32;
            dataRow["UnitsInStock"] = 9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 33;
            dataRow["ProductName"] = "Geitost";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "500 g";
            dataRow["UnitPrice"] = 2.5;
            dataRow["UnitsInStock"] = 112;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 34;
            dataRow["ProductName"] = "Sasquatch Ale";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 12 oz bottles";
            dataRow["UnitPrice"] = 14;
            dataRow["UnitsInStock"] = 111;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 35;
            dataRow["ProductName"] = "Steeleye Stout";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 12 oz bottles";
            dataRow["UnitPrice"] = 18;
            dataRow["UnitsInStock"] = 20;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 36;
            dataRow["ProductName"] = "Inlagd Sill";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "24 - 250 g  jars";
            dataRow["UnitPrice"] = 19;
            dataRow["UnitsInStock"] = 112;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 37;
            dataRow["ProductName"] = "Gravad lax";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "12 - 500 g pkgs.";
            dataRow["UnitPrice"] = 26;
            dataRow["UnitsInStock"] = 11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 38;
            dataRow["ProductName"] = "Côte de Blaye";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "12 - 75 cl bottles";
            dataRow["UnitPrice"] = 263.5;
            dataRow["UnitsInStock"] = 17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 39;
            dataRow["ProductName"] = "Chartreuse verte";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "750 cc per bottle";
            dataRow["UnitPrice"] = 18;
            dataRow["UnitsInStock"] = 69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 40;
            dataRow["ProductName"] = "Boston Crab Meat";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "24 - 4 oz tins";
            dataRow["UnitPrice"] = 18.4;
            dataRow["UnitsInStock"] = 123;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 41;
            dataRow["ProductName"] = "Jack's New England Clam Chowder";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "12 - 12 oz cans";
            dataRow["UnitPrice"] = 9.65;
            dataRow["UnitsInStock"] = 85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 42;
            dataRow["ProductName"] = "Singaporean Hokkien Fried Mee";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "32 - 1 kg pkgs.";
            dataRow["UnitPrice"] = 14;
            dataRow["UnitsInStock"] = 26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 43;
            dataRow["ProductName"] = "Ipoh Coffee";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "16 - 500 g tins";
            dataRow["UnitPrice"] = 46;
            dataRow["UnitsInStock"] = 17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 44;
            dataRow["ProductName"] = "Gula Malacca";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "20 - 2 kg bags";
            dataRow["UnitPrice"] = 19.45;
            dataRow["UnitsInStock"] = 27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 45;
            dataRow["ProductName"] = "Røgede sild";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "1k pkg.";
            dataRow["UnitPrice"] = 9.5;
            dataRow["UnitsInStock"] = 5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 46;
            dataRow["ProductName"] = "Spegesild";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "4 - 450 g glasses";
            dataRow["UnitPrice"] = 12;
            dataRow["UnitsInStock"] = 95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 47;
            dataRow["ProductName"] = "Zaanse koeken";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "10 - 4 oz boxes";
            dataRow["UnitPrice"] = 9.5;
            dataRow["UnitsInStock"] = 36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 48;
            dataRow["ProductName"] = "Chocolade";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "10 pkgs.";
            dataRow["UnitPrice"] = 12.75;
            dataRow["UnitsInStock"] = 15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 49;
            dataRow["ProductName"] = "Maxilaku";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "24 - 50 g pkgs.";
            dataRow["UnitPrice"] = 20;
            dataRow["UnitsInStock"] = 10;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 50;
            dataRow["ProductName"] = "Valkoinen suklaa";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "12 - 100 g bars";
            dataRow["UnitPrice"] = 16.25;
            dataRow["UnitsInStock"] = 65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 51;
            dataRow["ProductName"] = "Manjimup Dried Apples";
            dataRow["CategoryID"] = 7;
            dataRow["QuantityPerUnit"] = "50 - 300 g pkgs.";
            dataRow["UnitPrice"] = 53;
            dataRow["UnitsInStock"] = 20;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 52;
            dataRow["ProductName"] = "Filo Mix";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "16 - 2 kg boxes";
            dataRow["UnitPrice"] = 7;
            dataRow["UnitsInStock"] = 38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 53;
            dataRow["ProductName"] = "Perth Pasties";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "48 pieces";
            dataRow["UnitPrice"] = 32.8;
            dataRow["UnitsInStock"] = 0;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 54;
            dataRow["ProductName"] = "Tourtière";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "16 pies";
            dataRow["UnitPrice"] = 7.45;
            dataRow["UnitsInStock"] = 21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 55;
            dataRow["ProductName"] = "Pâté chinois";
            dataRow["CategoryID"] = 6;
            dataRow["QuantityPerUnit"] = "24 boxes x 2 pies";
            dataRow["UnitPrice"] = 24;
            dataRow["UnitsInStock"] = 115;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 56;
            dataRow["ProductName"] = "Gnocchi di nonna Alice";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "24 - 250 g pkgs.";
            dataRow["UnitPrice"] = 38;
            dataRow["UnitsInStock"] = 21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 57;
            dataRow["ProductName"] = "Ravioli Angelo";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "24 - 250 g pkgs.";
            dataRow["UnitPrice"] = 19.5;
            dataRow["UnitsInStock"] = 36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 58;
            dataRow["ProductName"] = "Escargots de Bourgogne";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "24 pieces";
            dataRow["UnitPrice"] = 13.25;
            dataRow["UnitsInStock"] = 62;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 59;
            dataRow["ProductName"] = "Raclette Courdavault";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "5 kg pkg.";
            dataRow["UnitPrice"] = 55;
            dataRow["UnitsInStock"] = 79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 60;
            dataRow["ProductName"] = "Camembert Pierrot";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "15 - 300 g rounds";
            dataRow["UnitPrice"] = 34;
            dataRow["UnitsInStock"] = 19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 61;
            dataRow["ProductName"] = "Sirop d'érable";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "24 - 500 ml bottles";
            dataRow["UnitPrice"] = 28.5;
            dataRow["UnitsInStock"] = 113;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 62;
            dataRow["ProductName"] = "Tarte au sucre";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "48 pies";
            dataRow["UnitPrice"] = 49.3;
            dataRow["UnitsInStock"] = 17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 63;
            dataRow["ProductName"] = "Vegie-spread";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "15 - 625 g jars";
            dataRow["UnitPrice"] = 43.9;
            dataRow["UnitsInStock"] = 24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 64;
            dataRow["ProductName"] = "Wimmers gute Semmelknödel";
            dataRow["CategoryID"] = 5;
            dataRow["QuantityPerUnit"] = "20 bags x 4 pieces";
            dataRow["UnitPrice"] = 33.25;
            dataRow["UnitsInStock"] = 22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 65;
            dataRow["ProductName"] = "Louisiana Fiery Hot Pepper Sauce";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "32 - 8 oz bottles";
            dataRow["UnitPrice"] = 21.05;
            dataRow["UnitsInStock"] = 76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 66;
            dataRow["ProductName"] = "Louisiana Hot Spiced Okra";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "24 - 8 oz jars";
            dataRow["UnitPrice"] = 17;
            dataRow["UnitsInStock"] = 4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 67;
            dataRow["ProductName"] = "Laughing Lumberjack Lager";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 12 oz bottles";
            dataRow["UnitPrice"] = 14;
            dataRow["UnitsInStock"] = 52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 68;
            dataRow["ProductName"] = "Scottish Longbreads";
            dataRow["CategoryID"] = 3;
            dataRow["QuantityPerUnit"] = "10 boxes x 8 pieces";
            dataRow["UnitPrice"] = 12.5;
            dataRow["UnitsInStock"] = 6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 69;
            dataRow["ProductName"] = "Gudbrandsdalsost";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "10 kg pkg.";
            dataRow["UnitPrice"] = 36;
            dataRow["UnitsInStock"] = 26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 70;
            dataRow["ProductName"] = "Outback Lager";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 355 ml bottles";
            dataRow["UnitPrice"] = 15;
            dataRow["UnitsInStock"] = 15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 71;
            dataRow["ProductName"] = "Fløtemysost";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "10 - 500 g pkgs.";
            dataRow["UnitPrice"] = 21.5;
            dataRow["UnitsInStock"] = 26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 72;
            dataRow["ProductName"] = "Mozzarella di Giovanni";
            dataRow["CategoryID"] = 4;
            dataRow["QuantityPerUnit"] = "24 - 200 g pkgs.";
            dataRow["UnitPrice"] = 34.8;
            dataRow["UnitsInStock"] = 14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 73;
            dataRow["ProductName"] = "Röd Kaviar";
            dataRow["CategoryID"] = 8;
            dataRow["QuantityPerUnit"] = "24 - 150 g jars";
            dataRow["UnitPrice"] = 15;
            dataRow["UnitsInStock"] = 101;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 74;
            dataRow["ProductName"] = "Longlife Tofu";
            dataRow["CategoryID"] = 7;
            dataRow["QuantityPerUnit"] = "5 kg pkg.";
            dataRow["UnitPrice"] = 10;
            dataRow["UnitsInStock"] = 4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 75;
            dataRow["ProductName"] = "Rhönbräu Klosterbier";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "24 - 0.5 l bottles";
            dataRow["UnitPrice"] = 7.75;
            dataRow["UnitsInStock"] = 125;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 76;
            dataRow["ProductName"] = "Lakkalikööri";
            dataRow["CategoryID"] = 1;
            dataRow["QuantityPerUnit"] = "500 ml";
            dataRow["UnitPrice"] = 18;
            dataRow["UnitsInStock"] = 57;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ProductID"] = 77;
            dataRow["ProductName"] = "Original Frankfurter grüne Soße";
            dataRow["CategoryID"] = 2;
            dataRow["QuantityPerUnit"] = "12 boxes";
            dataRow["UnitPrice"] = 13;
            dataRow["UnitsInStock"] = 32;
            table.Rows.Add(dataRow);

            return table;
        }
    }
}
