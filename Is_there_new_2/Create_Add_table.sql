CREATE TABLE BOOS.ADDS 
(
  ID_P VARCHAR2(20 BYTE) NOT NULL 
, PRODUCT_NAME VARCHAR2(150 BYTE) 
, PRICE VARCHAR2(20 BYTE) 
, DESCRIBE_OF_PRODUCT VARCHAR2(300 BYTE) 
, ID_PUB VARCHAR2(20 BYTE) 
, CONSTRAINT ADDS_PK PRIMARY KEY 
  (
    ID_P 
  )
  USING INDEX 
  (
      CREATE UNIQUE INDEX BOOS.ADDS_PK ON BOOS.ADDS (ID_P ASC) 
      LOGGING 
      TABLESPACE USERS 
      PCTFREE 10 
      INITRANS 2 
      STORAGE 
      ( 
        INITIAL 65536 
        MINEXTENTS 1 
        MAXEXTENTS UNLIMITED 
        BUFFER_POOL DEFAULT 
      ) 
      NOPARALLEL 
  )
  ENABLE 
) 
LOGGING 
TABLESPACE USERS 
PCTFREE 10 
INITRANS 1 
STORAGE 
( 
  INITIAL 65536 
  MINEXTENTS 1 
  MAXEXTENTS UNLIMITED 
  BUFFER_POOL DEFAULT 
) 
NOCOMPRESS 
NOPARALLEL;

ALTER TABLE BOOS.ADDS
ADD CONSTRAINT ADDS_FK1 FOREIGN KEY
(
  ID_PUB 
)
REFERENCES BOOS.PUBLISHER
(
  ID_PUB 
)
ENABLE;
