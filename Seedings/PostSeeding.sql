DECLARE @ID as INT;
DECLARE @Description as VARCHAR(MAx);
DECLARE @PostTypeId as INT;
DECLARE @PostSubTypeId as INT;
DECLARE @ScaleFrom as INT;
DECLARE @ScaleTo as INT;
DECLARE @NoOfPosts as INT;
DECLARE @VacantPosts as INT;
DECLARE @IsActive as INT;
DECLARE @PostStatusId as INT;
DECLARE @PermPosts as INT;
DECLARE @TempPosts as INT;
DECLARE @Qualification as  VARCHAR(MAx); 
DECLARE @Experience as  VARCHAR(MAx);	
DECLARE @JobDescription as VARCHAR(MAx);
DECLARE @AppointmentModeId as INT;
DECLARE @CreationDate as Date;
DECLARE @SanctionNumber as INT;
DECLARE @SanctionDate as Date;
DECLARE @Remarks as  VARCHAR(MAx);
DECLARE @PoolId as INT;
DECLARE @Upgradationdate as Date;
DECLARE @Urdu as  VARCHAR(MAx);
DECLARE @IsGazetted as INT;
declare @msg varchar(max)
DECLARE @Cursor as CURSOR;

SET @Cursor = CURSOR FOR
SELECT * from POSTS

OPEN @Cursor;
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@PostTypeId,@PostSubTypeId,@ScaleFrom,@ScaleTo,
	@NoOfPosts,@VacantPosts,@IsActive,@PostStatusId,@PermPosts,@TempPosts,@Qualification,@Experience,
	@JobDescription,@AppointmentModeId,@CreationDate,@SanctionNumber,
	@SanctionDate,@Remarks,@PoolId,@Upgradationdate,@Urdu,@IsGazetted;
    WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @msg ='new Post {'
			SET @msg += 'Id= ' + CONVERT(varchar(10), @ID) +','
            SET @msg += 'Description= "'+CONVERT(varchar(Max), @Description) +'",'
				IF(@IsActive=1)
                  SET @msg += 'IsActive=true,' 
				 ELSE  
				  SET @msg += 'IsActive=false,'
           
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
			IF(@PostTypeId<>NULL)
			SET @msg += 'PostTypeId= "'+CONVERT(varchar(Max), @PostTypeId) +'",'
			IF(@PostSubTypeId<>NULL)
			SET @msg += 'PostSubTypeId= "'+CONVERT(varchar(Max), @PostSubTypeId) +'",'
			IF(@PostStatusId<>NULL)
			SET @msg += 'PostStatusId= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			--SET @msg += 'IsGazetted= "'+CONVERT(varchar(Max), @PostStatusId) +'",'
			SET @msg +='},'
			
        print @msg
    FETCH NEXT FROM @Cursor INTO @ID,@Description,@PostTypeId,@PostSubTypeId,@ScaleFrom,@ScaleTo,@NoOfPosts,@VacantPosts,@IsActive,@PostStatusId,@PermPosts,@TempPosts,@Qualification,@Experience,@JobDescription,@AppointmentModeId,@CreationDate,@SanctionNumber,@SanctionDate,@Remarks,@PoolId,@Upgradationdate,@Urdu,@IsGazetted 
END

