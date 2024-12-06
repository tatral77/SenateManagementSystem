DECLARE @ID as INT;
DECLARE @Description as VARCHAR(MAx);
DECLARE @IsActive as VARCHAR(MAx);
DECLARE @ProvinceId as VARCHAR(MAx);
DECLARE @CountryId as VARCHAR(MAx);
DECLARE @IsDistrict as VARCHAR(MAx);

declare @msg varchar(max)
DECLARE @Cursor as CURSOR;

SET @Cursor = CURSOR FOR
SELECT * from CITIES

OPEN @Cursor;
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@ProvinceId,@CountryId,@IsDistrict,@IsActive;
    WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @msg ='new City {'
			SET @msg += 'Id= ' + CONVERT(varchar(10), @ID) +','
            SET @msg += 'Description= "'+CONVERT(varchar(Max), @Description) +'",'
				IF(@IsActive=1)
                  SET @msg += 'IsActive=true,' 
				 ELSE  
				  SET @msg += 'IsActive=false,'
				IF(@IsDistrict=1)
                  SET @msg += 'IsDistrict=true,' 
				 ELSE  
				  SET @msg += 'IsDistrict=false,'
			IF(@CountryId<>NULL)
              SET @msg += 'CountryId= "'+CONVERT(varchar(Max), @CountryId) +'",'
			  
			--SET @msg += 'BPSFrom= "'+CONVERT(varchar(Max), @ScaleFrom) +'",'
            --SET @msg += 'BPSTo= "'+CONVERT(varchar(Max), @ScaleTo) +'",'
			--SET @msg += 'NumberOfPosts= "'+CONVERT(varchar(Max), @NoOfPosts) +'",'
			--SET @msg += 'PermanentPosts= "'+CONVERT(varchar(Max), @PermPosts) +'",'
			--SET @msg += 'TemporaryPosts= "'+CONVERT(varchar(Max), @TempPosts) +'",'
			--SET @msg += 'RequiredQualification= "'+CONVERT(varchar(Max), @Qualification) +'",'
			--SET @msg += 'JobExperience= "'+CONVERT(varchar(Max), @Experience) +'",'
			--SET @msg += 'JobDescription= "'+CONVERT(varchar(Max), @JobDescription) +'",'
			--SET @msg += 'AppointmentModeId= "'+CONVERT(varchar(Max), @AppointmentModeId) +'",'
			--SET @msg += 'SanctionNumber= "'+CONVERT(varchar(Max), @SanctionNumber) +'",'
			--SET @msg += 'SanctionDate= "'+CONVERT(varchar(Max), @SanctionDate) +'",'
			--SET @msg += 'Remarks= "'+CONVERT(varchar(Max), @Remarks) +'",'
			--SET @msg += 'UpgradationDate= "'+CONVERT(varchar(Max), @Upgradationdate) +'",'
			--SET @msg += 'EmployeePoolsId= "'+CONVERT(varchar(Max), @PoolId) +'",'
			--IF(@PostTypeId<>NULL)
			--SET @msg += 'PostTypeId= "'+CONVERT(varchar(Max), @PostTypeId) +'",'
			--IF(@PostSubTypeId<>NULL)
			--SET @msg += 'PostSubTypeId= "'+CONVERT(varchar(Max), @PostSubTypeId) +'",'
			--IF(@PostStatusId<>NULL)
			--SET @msg += 'PostStatusId= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			----SET @msg += 'IsGazetted= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			SET @msg +='},'
			
        print @msg
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@ProvinceId,@CountryId,@IsDistrict,@IsActive;
END

