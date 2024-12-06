DECLARE @ID as INT;
DECLARE @Description as VARCHAR(MAx);
DECLARE @IsActive as VARCHAR(MAx);
DECLARE @ProvinceId as VARCHAR(MAx);
DECLARE @CountryId as VARCHAR(MAx);
DECLARE @IsDistrict as VARCHAR(MAx);

declare @msg varchar(max)
DECLARE @Cursor as CURSOR;

SET @Cursor = CURSOR FOR
SELECT * from COUNTRIES

OPEN @Cursor;
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@IsActive;
    WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @msg ='new Country {'
			SET @msg += 'Id= ' + CONVERT(varchar(10), @ID) +','
            SET @msg += 'Description= "'+CONVERT(varchar(Max), @Description) +'",'
				IF(@IsActive=1)
                  SET @msg += 'IsActive=true,' 
				 ELSE  
				  SET @msg += 'IsActive=false,'
			--IF(@PostTypeId<>NULL)
			--SET @msg += 'PostTypeId= "'+CONVERT(varchar(Max), @PostTypeId) +'",'
			--IF(@PostSubTypeId<>NULL)
			--SET @msg += 'PostSubTypeId= "'+CONVERT(varchar(Max), @PostSubTypeId) +'",'
			--IF(@PostStatusId<>NULL)
			--SET @msg += 'PostStatusId= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			----SET @msg += 'IsGazetted= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			SET @msg +='},'
			
        print @msg
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@IsActive;
END

