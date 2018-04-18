drop table Account;
drop table ItemBeli;
drop table ItemJual;
drop table FakturBeli;
drop table FakturJual;
drop table Stock;
drop table Pembayaran;
drop table Customer;
drop table Supplier;
drop table salesperson;

create table Account (_password varchar(100) primary key,
					  _role int default 0)
insert into Account values('admin', 0);

create table SalesPerson (_spid int primary key,
						_salesname varchar(max),
						_address varchar(max),
						_city varchar(20),
						_phone varchar(max),
						_notes varchar(max),
						_dateIn date,
						_komImport varchar(30),
						_komLocal varchar(30),
						_extra varchar(max));
insert into SalesPerson values (1, 'Cheli', '', '', '', '', '2018-01-01', 0, '', '', '');

create table Supplier (_sid int primary key,
						_city varchar(max),
						_name varchar(max),
						_address varchar(max),
						_phone varchar(max),
						_notes varchar(max),
						_jatuhTempo date,
						_creditDay int,
						_extra varchar(max));
insert into Supplier values (1, '', 'Cheli', '', '', '', null, 0, '');

create table Customer (_cid int primary key,
						_name varchar(max),
						_spid int foreign key references SalesPerson(_spid),
						_city varchar(max),
						_address1 varchar(max),
						_address2 varchar(max),
						_phone varchar(max),
						_notes varchar(max),
						_lamaKredit int,
						_marketibility bit,
						_nonpwp bigint,
						_namanpwp varchar(max),
						_addressnpwp varchar(max),
						_extra varchar(max));
insert into Customer values (1, 'Cheli', 1, '', '', '', '', '', 0, 0, 0, '', '', '');

create table Stock (_id int identity(0, 1) primary key,
					_stockCode varchar(40) unique,
					_name varchar(200) unique,
					_merk varchar(max),
					_color varchar(max),
					_sizeid varchar(max),
					_notes varchar(max),
					_unit varchar(5),
					_quantity int,
					_colly int,
					_price int,
					_suggestedPrice int,
					_weight decimal(10,3),
					_dimensions varchar(20),
					_category varchar(max),
					_dateList date,
					_make bit,
					_imageName varchar(max),
					_extra varchar(max));
insert into Stock (_stockcode, _name, _merk, _color, _sizeid, _notes, _unit, _quantity, _colly, _price, _suggestedPrice, _weight, _dimensions, _category, _dateList, _make, _imageName, _extra) values ('MJ0001', 'Meja Lantai', '', '', '', '', '', 0, 0, 0, 0, 0, '', '', null, 0, null, '');

create table FakturJual (_idJual int primary key,
						_date date,
						_ppn bit,
						_cashCredit bit,
						_JualReturn bit,
						_cid int foreign key references Customer(_cid),
						_jatuhTempo date,
						_tanggalLunas date,
						_extra varchar(max),
						_terbayar int default 0);
insert into FakturJual values (1, null, 0, 0, 0, 1, null, null, '', 0);

create table ItemJual (_itemid int identity(0, 1) primary key,
						_dateOut date,
						_fid int foreign key references FakturJual(_idJual),
						_stockid int foreign key references Stock(_id),
						_quantity int,
						_sellingPrice int,
						_baseprice int,
						_discount int,
						_extra varchar(max),
						_del bit);
insert into ItemJual (_fid, _dateOut, _stockid, _quantity, _sellingPrice, _baseprice, _discount, _extra, _del) values (1, null, 0, 0, 0, 0, 0, '', 0);

create table FakturBeli (_idBeli int primary key,
						_date date,
						_jatuhTempo date,
						_ppn bit,
						_cashCredit bit,
						_BeliReturn bit,
						_sid int foreign key references Supplier(_sid),
						_discount int,
						_noPajak varchar(max),
						_datePajak date,
						_extra varchar(max));
insert into FakturBeli values (0, null, null, 0, 0, 0, 1, 0, '', null, '');

create table ItemBeli (_itemid int identity(0, 1) primary key,
						_dateIn date,
						_fid int foreign key references FakturBeli(_idBeli),
						_sid int foreign key references Stock(_id),
						_buyingPrice int,
						_quantity int,
						_extra varchar(max),
						_del bit);
insert into ItemBeli (_dateIn, _fid, _sid, _buyingPrice, _quantity, _extra) values
(null, 0, 0, 0, 0, '');

create table Pembayaran (_nogiro varchar(100) primary key,
							_dategiro date,
							_namabank varchar(max),
							_norek varchar(max),
							_jatuhTempo date,
							_amount int,
							_sisa int,
							_discount int,
							_cid int foreign key references Customer(_cid),
							_noFaktur varchar(max),
							_sudahCair bit,
							_keterangan varchar(max),
							_extra varchar(max));


