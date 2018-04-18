using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // SELECT * FROM CUSTOMER WHERE CID = @cid
    // cmd.Parameters.AddWithValue("@cid", 'value');
    class QueryString
    {
        // Last 3 month data group by month, @d = selectedDate _dateIn = columnName
        //select MONTH(_dateIn), count(*) from SalesPerson where _dateIn >= DATEADD(MONTH, -3, DATEFROMPARTS(YEAR(@d), MONTH(@d), 1)) 
        //and _dateIn<DATEFROMPARTS(YEAR(@d), MONTH(@d), 1) group by DATEPART(month, _dateIn);
        
        // SalesPerson
        internal static string GetSalesPersons = "SELECT * FROM SalesPerson;";
        internal static string CountSales = "Select Count(_spid) from SalesPerson;";
        internal static string UpdateSalesPersonInfo = "UPDATE SalesPerson SET _salesname = @salesName, _address = @address, _city = @city, _phone = @phone, " +
            "_notes = @notes, _dateIn = @dateIn, _komImport = @komImport, _komLocal = @komLocal WHERE _spid = @spid";
        internal static string InsertSalesPerson = "INSERT INTO SalesPerson VALUES (@spid, @salesName, @address, @city, @phone, @notes, @dateIn, @komImport, @komLocal, @extra);";
        internal static string GetOmsetOrderByMake = "select _make, sum(_sellingprice * ij._quantity) as _totalomset from customer c join fakturjual fj on fj._cid = c._cid join" +
            " itemjual ij on ij._fid = fj._idJual join stock s on s._id = ij._stockid where c._spid = @spid and fj._Jualreturn = 0 and fj._tanggalLunas is null and " +
            "month(fj._date) = (select datepart(month, getdate())) and year(fj._date) = (select datepart(year, getdate())) and ij._del = 0 group by _make;";
        internal static string GetProfit = "select sum((ij._sellingprice - ij._discount - ij._baseprice) * ij._quantity) as _totalomset from customer c join fakturjual fj on fj._cid = c._cid join" +
            " itemjual ij on ij._fid = fj._idJual join stock s on s._id = ij._stockid where c._spid = @spid and fj._Jualreturn = 0 and fj._tanggalLunas is null and " +
            "month(fj._date) = (select datepart(month, getdate())) and year(fj._date) = (select datepart(year, getdate())) and ij._del = 0;";

        // Customer
        internal static string GetCustomers = "SELECT * FROM Customer JOIN SalesPerson on SalesPerson._spid = Customer._spid;";
        internal static string UpdateCustomerInfo = "UPDATE Customer set _name = @name , _spid = @salesId , _city = @city , _address1 = @addr1 , _address2 = @addr2 , " +
            "_phone = @phone , _notes = @notes , _lamaKredit = @lamaKredit , _marketibility = @market , _nonpwp = @npwpNum , _namanpwp = @npwpName , _addressnpwp = @npwpAddr " +
            "WHERE _cid = @cid;";
        internal static string InsertCustomers = "INSERT INTO CUSTOMER VALUES ((select count(_cid) from customer) + 1, @name, @salesId, @city, @addr1, @addr2, @phone, @notes, @lamaKredit, @market,  @npwpNum, @npwpName, @npwpAddr, 0);";
        internal static string CountCustomer = "Select Count(_cid) from Customer;";
        internal static string GetCustomerNameFromId = "SELECT _name FROM Customer WHERE _cid = @cid;";

        // Supplier
        internal static string GetSupplier = "SELECT * FROM Supplier;";
        internal static string InsertSupplier = "INSERT INTO Supplier (_sid, _city, _name, _address, _phone, _notes, _jatuhTempo, _creditDay, _extra) VALUES " +
            "((select count(_sid) from supplier) + 1, @city, @name, @address, @phone, @notes, null, @creditDay, @extra);";
        internal static string CountSupplier = "Select Count(_sid) from Supplier;";
        internal static string UpdateSupplierInfo = "UPDATE Supplier set _city = @city, _name = @name, _address = @addr, _phone = @phone, _notes = @notes, _creditDay = @credit where _sid = @sid;";
        internal static string GetSupplierCreditDay = "SELECT _creditDay FROM Supplier WHERE _sid = @sid;";

        //Stok
        internal static string GetStocks = "SELECT * FROM Stock;";
        internal static string GetStockIdFromStockCode = "SELECT _id FROM Stock WHERE _name = @name;";
        internal static string InsertStock = "INSERT INTO Stock VALUES (@code, @name, @merk, @color, @size, @notes, @unit, 0, @colly, @price, @suggested, @weight, @dim, @category, @date, @make, @imageName, @extra);";
        internal static string UpdateStockInfo = "UPDATE Stock SET _stockCode = @code, _name = @name, _merk = @merk, _color = @color, _unit = @unit, _colly = @colly, " +
            "_suggestedPrice = @suggested, _weight = @weight, _dimensions = @dim, _category = @category, _dateList = @date, _make = @make, _imageName = @imageName WHERE _id = @id";

        internal static string GetStockQty = "Select _quantity from stock where _id = @id";
        internal static string GetStockPrice = "Select _price from stock where _id = @id";
        internal static string GetDateInFromStockid = "SELECT MAX(_DATEIN) FROM ITEMBELI WHERE _SID = @id;";
        internal static string UpdateStockQty = "Update Stock SET _price = @stockprice, _quantity = @qty where _id = @stockid;";
        internal static string UpdateStockQuantity = "UPDATE Stock SET _quantity = @quantityStock WHERE _id = @stockid;";


        // FakturJual
        internal static string GetFakturJuals = "SELECT * FROM FakturJual fj JOIN Customer c ON fj._cid = c._cid;";
        internal static string InsertFakturJual = "INSERT INTO FakturJual VALUES (@id, @date, @ppn, @cashCredit, @jualReturn, " +
            "@cid, @jatuhTempo, @lunasDate, @extra, 0);";
        internal static string UpdateFakturJual = "UPDATE FakturJual SET _jatuhTempo = @jatuhTempo, _ppn = @ppn, _cashCredit = @cashCredit, " +
            "_jualReturn = @jualReturn, _cid = @cid, _extra = @extra, _tanggallunas = @lunasdate " +
            "WHERE _idJual = @id;";
        // Total -= SUM(fj._terbayar) ?
        internal static string GetFakturLast3MonthsGroupByMonth = "SELECT MONTH(@d) - MONTH(fj._date) as BulanMinus, fj._JualReturn as Jual, SUM(ij._quantity * ij._sellingPrice) as Total FROM " +
            "FakturJual fj JOIN ItemJual ij ON fj._idJual = ij._fid WHERE fj._cid = @cid AND fj._date >= DATEADD(MONTH, -2, DATEFROMPARTS(YEAR(@d), MONTH(@d), 1)) AND ij._del = 0" +
            " GROUP BY MONTH(fj._date), fj._JualReturn ORDER BY Jual, BulanMinus;";
        internal static string GetTotalPiutangOrderByJual = "SELECT fj._JualReturn as Jual, SUM(ij._quantity* ij._sellingPrice) as Total FROM " +
            "FakturJual fj JOIN ItemJual ij ON fj._idJual = ij._fid WHERE fj._cid = @cid AND fj._tanggalLunas is null and ij._del = 0 " +
            "GROUP BY fj._JualReturn ORDER BY Jual;";
        internal static string FakturJualJatuhTempoFromCustomer = "SELECT MIN(fj._jatuhTempo) FROM FakturJual fj WHERE fj._cid = @customerid AND fj._tanggalLunas is null;";
        internal static string countFakturJualInMonth = "SELECT COUNT(*) FROM fakturjual WHERE month(_date) = (select datepart(month, getdate()))";


        // ItemJual
        internal static string GetItemJual = "SELECT * FROM ItemJual join stock on itemjual._stockid = stock._id WHERE _fid = @fid and _del = 0;";
        internal static string InsertItemJual = "INSERT INTO ItemJual VALUES (@date, @fid, @sid, @quantity, @price, @baseprice, @discount, @extra, @del);";
        internal static string UpdateItemJual = "UPDATE ItemJual SET _baseprice = @baseprice, _sellingPrice = @sellingprice, _quantity = @quantity, _discount = @discount where _itemId = @itemid;";
        internal static string GetItemJualTotal = "SELECT _sellingPrice * _quantity AS _total FROM ItemJual WHERE _itemId = @id and _del = 0;";
        internal static string GetItemJualQuantity = "SELECT _quantity FROM ItemJual WHERE _itemId = @id;";
        internal static string DeleteItemJual = "UPDATE ITEMJUAL SET _DEL = 1 WHERE _ITEMID = @itemid;";

        // FakturBeli
        internal static string GetFakturBeli = "SELECT * FROM FakturBeli Join Supplier on FakturBeli._sid = Supplier._sid;";
        internal static string InsertFakturBeli = "INSERT INTO FakturBeli values (@id, @date, @jatuhTempo, @ppn, @cashCredit," +
            " @beliReturn, @sid, @discount, @nomorPajak, @datePajak, @extra);";
        //"UPDATE FakturBeli SET _jatuhTempo = @jatuhTempo, _ppn = @ppn, _cashCredit = @cashCredit, " +
        //    "_beliReturn = @beliReturn, _discount = @discount, _noPajak = @nomorPajak, _sid = @sid, _datePajak = @datePajak, _extra = @extra " +
        //    "WHERE _idBeli = @id;"
        internal static string UpdateFakturBeli = "UPDATE FakturBeli SET _ppn = @ppn, _cashCredit = @cashCredit, " +
            "_beliReturn = @beliReturn, _discount = @discount, _noPajak = @nomorPajak, _sid = @sid, _datePajak = @datePajak, _extra = @extra " +
            "WHERE _idBeli = @id;";

        internal static string countFakturBeliInMonth = "SELECT COUNT(*) FROM fakturbeli WHERE month(_date) = (select datepart(month, getdate()))"; 

        // ItemBeli
        internal static string GetItemBeli = "SELECT * FROM ItemBeli join stock on itembeli._sid = stock._id  WHERE _fid = @fid and _del = 0;";
        internal static string InsertItemBeli = "INSERT INTO ItemBeli values (@date, @fid, @sid, @price, @quantity, @extra, @del)";
        internal static string UpdateItemBeli = "UPDATE ItemBeli SET _buyingPrice = @price, _quantity = @quantity where _itemId = @id;";
        internal static string GetItemBeliTotal = "SELECT _buyingPrice, _quantity FROM ItemBeli WHERE _itemId = @id and _del = 0;";
        internal static string GetStockQuantityFromItemBeli = "SELECT sum(_quantity) FROM ItemBeli WHERE _sid = @sid;";
        internal static string DeleteItemBeli = "UPDATE ITEMBELI SET _DEL = 1 WHERE _ITEMID = @itemid;";

        //Password
        internal static string InsertAccount = "INSERT INTO ACCOUNT VALUES (@password, @role);";
        internal static string UpdateAccount = "UPDATE ACCOUNT SET _PASSWORD = @newpass where _PASSWORD = @oldpass;";
        internal static string AccountRole = "SELECT _role FROM Account WHERE _password = @password;";

        //Piutang
        internal static string GetPiutang = "Select _idjual, _date, _name, _jatuhtempo, c._cid, _spid, _city, SUM(_sellingPrice * _quantity) as _total from fakturjual" +
            " fj join itemjual ij on fj._idJual = ij._fid join customer c on fj._cid = c._cid where _jualReturn = 0 and _del = 0 group by _idJual, _Date," +
            " _name, _jatuhtempo, c._cid, _spid, _city;";

        //Fix query
        //Select Count(_idjual) from (Select _idjual, _cid, SUM(_quantity * _sellingprice) as tatal from fakturjual fj join itemjual ij on fj._idJual = ij._fid where _jualReturn = 0 and _del = 0 group by _idjual, _cid) test group by test._cid;

        //Pembayaran
        internal static string GetPembayaran = "SELECT * FROM PEMBAYARAN PB JOIN CUSTOMER C ON PB._CID = C._CID;";
        internal static string InsertPembayaran = "INSERT INTO PEMBAYARAN VALUES (@nogiro, @dategiro, @namabank, @norek, @jatuhtempo," +
            " @amount, @sisa, @discount, @cid, @nofaktur, @sudahcair, @keterangan, @extra);";
        internal static string GetFakturJualFromCid = "SELECT _idJual FROM FakturJual WHERE _cid = @customerid AND _tanggalLunas is null;";
    }
}
