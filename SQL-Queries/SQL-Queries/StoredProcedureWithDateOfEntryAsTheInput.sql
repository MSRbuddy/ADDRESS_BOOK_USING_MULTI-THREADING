create procedure dbo.SpAddcontactRecordsWithDateOfEntry
(	
	@fname	varchar(50),
	@sname	varchar(50),		
	@address varchar(50),		
	@city varchar(50),		
	@state	varchar(50),	
	@zip   bigint,		
	@phoneNo   bigint,
	@email varchar(50),
	@type varchar(50),	
	@bookName varchar(50),
	@entryDate date
)
	as begin
	Insert into addressBookDatabase values(@fname,@sname,@address,@city,@state,@zip,@phoneNo,@email,@type,@bookName, @entryDate)
	End
-- Testing the stored procedure to adding the data to the address book using the inputs
use addressBook_services;
select * from addressBookDatabase;
EXEC SpAddcontactRecordsWithDateOfEntry @fname='Deekshitha', @sname ='Macha', @address ='Sec-1', @city = 'Nizamabad', @state = 'TS', @zip = 276123, @phoneNo = 98784565,
@email = 'deekshitha@gmail.com', @type = 'Family', @bookName = 'MyRecord', @entryDate = '2018-06-09';