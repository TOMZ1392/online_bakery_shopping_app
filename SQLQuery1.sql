

Create table BAKE_TYPE(
BAKE_TYPE_ID int IDENTITY NOT NULL,
BAKE_TYP_NAME char(30) NOT  NULL,
AVAILABILITY_FLAG INT,
BAKE_TYPE_DISCOUNT int,
IMAGE_PATH CHAR(200),
COUNT_ITEMS INT,
COUNT_PURCHASE INT
)
drop procedure INSERTPRODTYPE
create procedure INSERTPRODTYPE(@name char(30),@avl_flg int,@discount int,@img_path char(200),@ct_items int,@ct_purchase int)
AS
BEGIN
INSERT INTO BAKE_TYPE(BAKE_TYP_NAME,AVAILABILITY_FLAG,BAKE_TYPE_DISCOUNT,IMAGE_PATH,COUNT_ITEMS,COUNT_PURCHASE)
VALUES(@name ,@avl_flg ,@discount ,@img_path ,@ct_items ,@ct_purchase ); 
END


Create table BAKE_PRODUCT(
BAKE_PROD_ID int IDENTITY NOT NULL,
BAKE_TYPE_ID int NOT NULL,
BAKE_TYP_NAME char(30) NOT  NULL,
BAKE_PROD_NAME  char(30) NOT  NULL,
PRICE float,
PROD_QTY int,
PROD_AVAILABILITY_FLG int,
PREP_TIME INT,
IMAGE_PATH char(200),
PROD_DISCOUNT int,
IS_BEST_SELLER int,
PROD_PURCHASE_COUNT int
)

create table tbltst(
	empid int
)

insert into tbltst values(665)

select max(empid) from tbltst


select * from BAKE_TYPE
truncate table BAKE_TYPE
INSERTPRODTYPE 'TOM',1,10,'D:/dasd/dassa/dasd\dasds',0,0