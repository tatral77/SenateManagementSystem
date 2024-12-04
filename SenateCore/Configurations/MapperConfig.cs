using AutoMapper;
using EstablishmentENT;
using SenateCore.Models.CommonModels.BasicPayScaleModel;
using SenateCore.Models.CommonModels.BillOriginModel;
using SenateCore.Models.CommonModels.BillStatusModel;
using SenateCore.Models.CommonModels.BillTypeModel;
using SenateCore.Models.CommonModels.BranchModel;
using SenateCore.Models.CommonModels.CityModel;
using SenateCore.Models.CommonModels.ConstituencyModel;
using SenateCore.Models.CommonModels.ContractTypeModel;
using SenateCore.Models.CommonModels.CountryModel;
using SenateCore.Models.CommonModels.CourseTypeModel;
using SenateCore.Models.CommonModels.DistrictModel;
using SenateCore.Models.CommonModels.DivisionModel;
using SenateCore.Models.CommonModels.EducationLevelModel;
using SenateCore.Models.CommonModels.ElectionTypeModel;
using SenateCore.Models.CommonModels.GenderModel;
using SenateCore.Models.CommonModels.HouseAffiliationModel;
using SenateCore.Models.CommonModels.LeaveTypeModel;
using SenateCore.Models.CommonModels.MaritalStatusModel;
using SenateCore.Models.CommonModels.MemberStatusModel;
using SenateCore.Models.CommonModels.MinistryModel;
using SenateCore.Models.CommonModels.MotionStatusModel;
using SenateCore.Models.CommonModels.MotionTypeModel;
using SenateCore.Models.CommonModels.NOCTypeModel;
using SenateCore.Models.CommonModels.ParliamentarySessionModel;
using SenateCore.Models.CommonModels.ParliamentarySessionSittingModel;
using SenateCore.Models.CommonModels.ParliamentaryTenureModel;
using SenateCore.Models.CommonModels.ParliamentaryTermModel;
using SenateCore.Models.CommonModels.ParliamentaryYearModel;
using SenateCore.Models.CommonModels.PartyDesignationModel;
using SenateCore.Models.CommonModels.PassportTypeModel;
using SenateCore.Models.CommonModels.PenaltyTypeModel;
using SenateCore.Models.CommonModels.PhoneTypeModel;
using SenateCore.Models.CommonModels.PoliticalPartyModel;
using SenateCore.Models.CommonModels.PostModel;
using SenateCore.Models.CommonModels.PostStatusModel;
using SenateCore.Models.CommonModels.PostTypeModel;
using SenateCore.Models.CommonModels.ProbationTypeModel;
using SenateCore.Models.CommonModels.ProvinceModel;
using SenateCore.Models.CommonModels.RelationModel;
using SenateCore.Models.CommonModels.ReligionModel;
using SenateCore.Models.CommonModels.ResolutionStatusModel;
using SenateCore.Models.CommonModels.ResolutionTypeModel;
using SenateCore.Models.CommonModels.SeatTypeModel;
using SenateCore.Models.CommonModels.SenateUserModel;
using SenateCore.Models.CommonModels.SittingTypeModel;
using SenateCore.Models.CommonModels.VisitTypeModel;
using SenateData.Common;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            #region BasicPayScale
            CreateMap<BasicPayScale, CreateBasicPayScaleDto>().ReverseMap();
            CreateMap<BasicPayScale, UpdateBasicPayScaleDto>().ReverseMap();
            CreateMap<BasicPayScale, GetBasicPayScaleDto>().ReverseMap();
            CreateMap<BasicPayScale, BaseBasicPayScaleDto>().ReverseMap();
            CreateMap<BasicPayScale, BasicPayScaleDto>().ReverseMap();
            #endregion
            #region BillOrigin
            CreateMap<BillOrigin, CreateBillOriginDto>().ReverseMap();
            CreateMap<BillOrigin, UpdateBillOriginDto>().ReverseMap();
            CreateMap<BillOrigin, GetBillOriginDto>().ReverseMap();
            CreateMap<BillOrigin, BaseBillOriginDto>().ReverseMap();
            CreateMap<BillOrigin, BillOriginDto>().ReverseMap();
            #endregion
            #region BillStatus
            CreateMap<BillStatus, CreateBillStatusDto>().ReverseMap();
            CreateMap<BillStatus, UpdateBillStatusDto>().ReverseMap();
            CreateMap<BillStatus, GetBillStatusDto>().ReverseMap();
            CreateMap<BillStatus, BaseBillStatusDto>().ReverseMap();
            CreateMap<BillStatus, BillStatusDto>().ReverseMap();
            #endregion
            #region BillType
            CreateMap<BillType, CreateBillTypeDto>().ReverseMap();
            CreateMap<BillType, UpdateBillTypeDto>().ReverseMap();
            CreateMap<BillType, GetBillTypeDto>().ReverseMap();
            CreateMap<BillType, BaseBillTypeDto>().ReverseMap();
            CreateMap<BillType, BillTypeDto>().ReverseMap();
            #endregion
            #region Branch
            CreateMap<Branch, CreateBranchDto>().ReverseMap();
            CreateMap<Branch, UpdateBranchDto>().ReverseMap();
            CreateMap<Branch, GetBranchDto>().ReverseMap();
            CreateMap<Branch, BaseBranchDto>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            #endregion
            #region City
            CreateMap<City, CreateCityDto>().ReverseMap();
            CreateMap<City, UpdateCityDto>().ReverseMap();
            CreateMap<City, GetCityDto>().ReverseMap();
            CreateMap<City, BaseCityDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            #endregion
            #region Constituency
            CreateMap<Constituency, CreateConstituencyDto>().ReverseMap();
            CreateMap<Constituency, UpdateConstituencyDto>().ReverseMap();
            CreateMap<Constituency, GetConstituencyDto>().ReverseMap();
            CreateMap<Constituency, BaseConstituencyDto>().ReverseMap();
            CreateMap<Constituency, ConstituencyDto>().ReverseMap();
            #endregion
            #region ContractType
            CreateMap<ContractType, CreateContractTypeDto>().ReverseMap();
            CreateMap<ContractType, UpdateContractTypeDto>().ReverseMap();
            CreateMap<ContractType, GetContractTypeDto>().ReverseMap();
            CreateMap<ContractType, BaseContractTypeDto>().ReverseMap();
            CreateMap<ContractType, ContractTypeDto>().ReverseMap();
            #endregion
            #region Country
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, BaseCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            #endregion
            #region CourseType
            CreateMap<CourseType, CreateCourseTypeDto>().ReverseMap();
            CreateMap<CourseType, UpdateCourseTypeDto>().ReverseMap();
            CreateMap<CourseType, GetCourseTypeDto>().ReverseMap();
            CreateMap<CourseType, BaseCourseTypeDto>().ReverseMap();
            CreateMap<CourseType, CourseTypeDto>().ReverseMap();
            #endregion
            #region District
            CreateMap<District, CreateDistrictDto>().ReverseMap();
            CreateMap<District, UpdateDistrictDto>().ReverseMap();
            CreateMap<District, GetDistrictDto>().ReverseMap();
            CreateMap<District, BaseDistrictDto>().ReverseMap();
            CreateMap<District, DistrictDto>().ReverseMap();
            #endregion
            #region Division
            CreateMap<MinistryDivision, CreateDivisionDto>().ReverseMap();
            CreateMap<MinistryDivision, UpdateDivisionDto>().ReverseMap();
            CreateMap<MinistryDivision, GetDivisionDto>().ReverseMap();
            CreateMap<MinistryDivision, BaseDivisionDto>().ReverseMap();
            CreateMap<MinistryDivision, DivisionDto>().ReverseMap();
            #endregion
            #region EducationLevel
            CreateMap<EducationLevel, CreateEducationLevelDto>().ReverseMap();
            CreateMap<EducationLevel, UpdateEducationLevelDto>().ReverseMap();
            CreateMap<EducationLevel, GetEducationLevelDto>().ReverseMap();
            CreateMap<EducationLevel, BaseEducationLevelDto>().ReverseMap();
            CreateMap<EducationLevel, EducationLevelDto>().ReverseMap();
            #endregion
            #region ElectionType
            CreateMap<ElectionType, CreateElectionTypeDto>().ReverseMap();
            CreateMap<ElectionType, UpdateElectionTypeDto>().ReverseMap();
            CreateMap<ElectionType, GetElectionTypeDto>().ReverseMap();
            CreateMap<ElectionType, BaseElectionTypeDto>().ReverseMap();
            CreateMap<ElectionType, ElectionTypeDto>().ReverseMap();
            #endregion
            #region Gender
            CreateMap<Gender, CreateGenderDto>().ReverseMap();
            CreateMap<Gender, UpdateGenderDto>().ReverseMap();
            CreateMap<Gender, GetGenderDto>().ReverseMap();
            CreateMap<Gender, BaseGenderDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            #endregion
            #region HouseAffiliation
            CreateMap<HouseAffiliation, CreateHouseAffiliationDto>().ReverseMap();
            CreateMap<HouseAffiliation, UpdateHouseAffiliationDto>().ReverseMap();
            CreateMap<HouseAffiliation, GetHouseAffiliationDto>().ReverseMap();
            CreateMap<HouseAffiliation, BaseHouseAffiliationDto>().ReverseMap();
            CreateMap<HouseAffiliation, HouseAffiliationDto>().ReverseMap();
            #endregion
            #region LeaveType
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, UpdateLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, GetLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, BaseLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            #endregion
            #region MaritalStatus
            CreateMap<MaritalStatus, CreateMaritalStatusDto>().ReverseMap();
            CreateMap<MaritalStatus, UpdateMaritalStatusDto>().ReverseMap();
            CreateMap<MaritalStatus, GetMaritalStatusDto>().ReverseMap();
            CreateMap<MaritalStatus, BaseMaritalStatusDto>().ReverseMap();
            CreateMap<MaritalStatus, MaritalStatusDto>().ReverseMap();
            #endregion
            #region MemberStatus
            CreateMap<MemberStatus, CreateMemberStatusDto>().ReverseMap();
            CreateMap<MemberStatus, UpdateMemberStatusDto>().ReverseMap();
            CreateMap<MemberStatus, GetMemberStatusDto>().ReverseMap();
            CreateMap<MemberStatus, BaseMemberStatusDto>().ReverseMap();
            CreateMap<MemberStatus, MemberStatusDto>().ReverseMap();
            #endregion
            #region Ministry
            CreateMap<Ministry, CreateMinistryDto>().ReverseMap();
            CreateMap<Ministry, UpdateMinistryDto>().ReverseMap();
            CreateMap<Ministry, GetMinistryDto>().ReverseMap();
            CreateMap<Ministry, BaseMinistryDto>().ReverseMap();
            CreateMap<Ministry, MinistryDto>().ReverseMap();
            #endregion
            #region MotionStatus
            CreateMap<MotionStatus, CreateMotionStatusDto>().ReverseMap();
            CreateMap<MotionStatus, UpdateMotionStatusDto>().ReverseMap();
            CreateMap<MotionStatus, GetMotionStatusDto>().ReverseMap();
            CreateMap<MotionStatus, BaseMotionStatusDto>().ReverseMap();
            CreateMap<MotionStatus, MotionStatusDto>().ReverseMap();
            #endregion
            #region MotionType
            CreateMap<MotionType, CreateMotionTypeDto>().ReverseMap();
            CreateMap<MotionType, UpdateMotionTypeDto>().ReverseMap();
            CreateMap<MotionType, GetMotionTypeDto>().ReverseMap();
            CreateMap<MotionType, BaseMotionTypeDto>().ReverseMap();
            CreateMap<MotionType, MotionTypeDto>().ReverseMap();
            #endregion
            #region NOCType
            CreateMap<NOCType, CreateNOCTypeDto>().ReverseMap();
            CreateMap<NOCType, UpdateNOCTypeDto>().ReverseMap();
            CreateMap<NOCType, GetNOCTypeDto>().ReverseMap();
            CreateMap<NOCType, BaseNOCTypeDto>().ReverseMap();
            CreateMap<NOCType, NOCTypeDto>().ReverseMap();
            #endregion
            #region ParliamentarySession
            CreateMap<ParliamentarySession, CreateParliamentarySessionDto>().ReverseMap();
            CreateMap<ParliamentarySession, UpdateParliamentarySessionDto>().ReverseMap();
            CreateMap<ParliamentarySession, GetParliamentarySessionDto>().ReverseMap();
            CreateMap<ParliamentarySession, BaseParliamentarySessionDto>().ReverseMap();
            CreateMap<ParliamentarySession, ParliamentarySessionDto>().ReverseMap();
            #endregion
            #region ParliamentaryTenure
            CreateMap<ParliamentaryTenure, CreateParliamentaryTenureDto>().ReverseMap();
            CreateMap<ParliamentaryTenure, UpdateParliamentaryTenureDto>().ReverseMap();
            CreateMap<ParliamentaryTenure, GetParliamentaryTenureDto>().ReverseMap();
            CreateMap<ParliamentaryTenure, BaseParliamentaryTenureDto>().ReverseMap();
            CreateMap<ParliamentaryTenure, ParliamentaryTenureDto>().ReverseMap();
            #endregion
            #region ParliamentaryTerm
            CreateMap<ParliamentaryTerm, CreateParliamentaryTermDto>().ReverseMap();
            CreateMap<ParliamentaryTerm, UpdateParliamentaryTermDto>().ReverseMap();
            CreateMap<ParliamentaryTerm, GetParliamentaryTermDto>().ReverseMap();
            CreateMap<ParliamentaryTerm, BaseParliamentaryTermDto>().ReverseMap();
            CreateMap<ParliamentaryTerm, ParliamentaryTermDto>().ReverseMap();
            #endregion
            #region ParliamentaryYear
            CreateMap<ParliamentaryYear, CreateParliamentaryYearDto>().ReverseMap();
            CreateMap<ParliamentaryYear, UpdateParliamentaryYearDto>().ReverseMap();
            CreateMap<ParliamentaryYear, GetParliamentaryYearDto>().ReverseMap();
            CreateMap<ParliamentaryYear, BaseParliamentaryYearDto>().ReverseMap();
            CreateMap<ParliamentaryYear, ParliamentaryYearDto>().ReverseMap();
            #endregion
            #region PartyDesignation
            CreateMap<PartyDesignation, CreatePartyDesignationDto>().ReverseMap();
            CreateMap<PartyDesignation, UpdatePartyDesignationDto>().ReverseMap();
            CreateMap<PartyDesignation, GetPartyDesignationDto>().ReverseMap();
            CreateMap<PartyDesignation, BasePartyDesignationDto>().ReverseMap();
            CreateMap<PartyDesignation, PartyDesignationDto>().ReverseMap();
            #endregion
            #region PassportType
            CreateMap<PassportType, CreatePassportTypeDto>().ReverseMap();
            CreateMap<PassportType, UpdatePassportTypeDto>().ReverseMap();
            CreateMap<PassportType, GetPassportTypeDto>().ReverseMap();
            CreateMap<PassportType, BasePassportTypeDto>().ReverseMap();
            CreateMap<PassportType, PassportTypeDto>().ReverseMap();
            #endregion
            #region PenaltyType
            CreateMap<PenaltyType, CreatePenaltyTypeDto>().ReverseMap();
            CreateMap<PenaltyType, UpdatePenaltyTypeDto>().ReverseMap();
            CreateMap<PenaltyType, GetPenaltyTypeDto>().ReverseMap();
            CreateMap<PenaltyType, BasePenaltyTypeDto>().ReverseMap();
            CreateMap<PenaltyType, PenaltyTypeDto>().ReverseMap();
            #endregion
            #region PhoneType
            CreateMap<PhoneType, CreatePhoneTypeDto>().ReverseMap();
            CreateMap<PhoneType, UpdatePhoneTypeDto>().ReverseMap();
            CreateMap<PhoneType, GetPhoneTypeDto>().ReverseMap();
            CreateMap<PhoneType, BasePhoneTypeDto>().ReverseMap();
            CreateMap<PhoneType, PhoneTypeDto>().ReverseMap();
            #endregion
            #region PoliticalParty
            CreateMap<PoliticalParty, CreatePoliticalPartyDto>().ReverseMap();
            CreateMap<PoliticalParty, UpdatePoliticalPartyDto>().ReverseMap();
            CreateMap<PoliticalParty, GetPoliticalPartyDto>().ReverseMap();
            CreateMap<PoliticalParty, BasePoliticalPartyDto>().ReverseMap();
            CreateMap<PoliticalParty, PoliticalPartyDto>().ReverseMap();
            #endregion
            #region Post
            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<Post, UpdatePostDto>().ReverseMap();
            CreateMap<Post, GetPostDto>().ReverseMap();
            CreateMap<Post, BasePostDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            #endregion
            #region PostStatus
            CreateMap<PostStatus, CreatePostStatusDto>().ReverseMap();
            CreateMap<PostStatus, UpdatePostStatusDto>().ReverseMap();
            CreateMap<PostStatus, GetPostStatusDto>().ReverseMap();
            CreateMap<PostStatus, BasePostStatusDto>().ReverseMap();
            CreateMap<PostStatus, PostStatusDto>().ReverseMap();
            #endregion
            #region PostType
            CreateMap<PostType, CreatePostTypeDto>().ReverseMap();
            CreateMap<PostType, UpdatePostTypeDto>().ReverseMap();
            CreateMap<PostType, GetPostTypeDto>().ReverseMap();
            CreateMap<PostType, BasePostTypeDto>().ReverseMap();
            CreateMap<PostType, PostTypeDto>().ReverseMap();
            #endregion
            #region ProbationType
            CreateMap<ProbationType, CreateProbationTypeDto>().ReverseMap();
            CreateMap<ProbationType, UpdateProbationTypeDto>().ReverseMap();
            CreateMap<ProbationType, GetProbationTypeDto>().ReverseMap();
            CreateMap<ProbationType, BaseProbationTypeDto>().ReverseMap();
            CreateMap<ProbationType, ProbationTypeDto>().ReverseMap();
            #endregion
            #region Province
            CreateMap<Province, CreateProvinceDto>().ReverseMap();
            CreateMap<Province, UpdateProvinceDto>().ReverseMap();
            CreateMap<Province, GetProvinceDto>().ReverseMap();
            CreateMap<Province, BaseProvinceDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
            #endregion
            #region Relation
            CreateMap<Relation, CreateRelationDto>().ReverseMap();
            CreateMap<Relation, UpdateRelationDto>().ReverseMap();
            CreateMap<Relation, GetRelationDto>().ReverseMap();
            CreateMap<Relation, BaseRelationDto>().ReverseMap();
            CreateMap<Relation, RelationDto>().ReverseMap();
            #endregion
            #region Religion
            CreateMap<Religion, CreateReligionDto>().ReverseMap();
            CreateMap<Religion, UpdateReligionDto>().ReverseMap();
            CreateMap<Religion, GetReligionDto>().ReverseMap();
            CreateMap<Religion, BaseReligionDto>().ReverseMap();
            CreateMap<Religion, ReligionDto>().ReverseMap();
            #endregion
            #region ResolutionStatus
            CreateMap<ResolutionStatus, CreateResolutionStatusDto>().ReverseMap();
            CreateMap<ResolutionStatus, UpdateResolutionStatusDto>().ReverseMap();
            CreateMap<ResolutionStatus, GetResolutionStatusDto>().ReverseMap();
            CreateMap<ResolutionStatus, BaseResolutionStatusDto>().ReverseMap();
            CreateMap<ResolutionStatus, ResolutionStatusDto>().ReverseMap();
            #endregion
            #region ResolutionType
            CreateMap<ResolutionType, CreateResolutionTypeDto>().ReverseMap();
            CreateMap<ResolutionType, UpdateResolutionTypeDto>().ReverseMap();
            CreateMap<ResolutionType, GetResolutionTypeDto>().ReverseMap();
            CreateMap<ResolutionType, BaseResolutionTypeDto>().ReverseMap();
            CreateMap<ResolutionType, ResolutionTypeDto>().ReverseMap();
            #endregion
            #region SeatType
            CreateMap<SeatType, CreateSeatTypeDto>().ReverseMap();
            CreateMap<SeatType, UpdateSeatTypeDto>().ReverseMap();
            CreateMap<SeatType, GetSeatTypeDto>().ReverseMap();
            CreateMap<SeatType, BaseSeatTypeDto>().ReverseMap();
            CreateMap<SeatType, SeatTypeDto>().ReverseMap();
            #endregion
            #region SenateUser
            CreateMap<SenateUser, CreateSenateUserDto>().ReverseMap();
            CreateMap<SenateUser, UpdateSenateUserDto>().ReverseMap();
            CreateMap<SenateUser, GetSenateUserDto>().ReverseMap();
            CreateMap<SenateUser, BaseSenateUserDto>().ReverseMap();
            CreateMap<SenateUser, SenateUserDto>().ReverseMap();
            #endregion
            #region ParliamentarySessionSitting
            CreateMap<ParliamentarySessionSitting, CreateParliamentarySessionSittingDto>().ReverseMap();
            CreateMap<ParliamentarySessionSitting, UpdateParliamentarySessionSittingDto>().ReverseMap();
            CreateMap<ParliamentarySessionSitting, GetParliamentarySessionSittingDto>().ReverseMap();
            CreateMap<ParliamentarySessionSitting, BaseParliamentarySessionSittingDto>().ReverseMap();
            CreateMap<ParliamentarySessionSitting, ParliamentarySessionSittingDto>().ReverseMap();
            #endregion
            #region SittingType
            CreateMap<SittingType, CreateSittingTypeDto>().ReverseMap();
            CreateMap<SittingType, UpdateSittingTypeDto>().ReverseMap();
            CreateMap<SittingType, GetSittingTypeDto>().ReverseMap();
            CreateMap<SittingType, BaseSittingTypeDto>().ReverseMap();
            CreateMap<SittingType, SittingTypeDto>().ReverseMap();
            #endregion
            #region VisitType
            CreateMap<VisitType, CreateVisitTypeDto>().ReverseMap();
            CreateMap<VisitType, UpdateVisitTypeDto>().ReverseMap();
            CreateMap<VisitType, GetVisitTypeDto>().ReverseMap();
            CreateMap<VisitType, BaseVisitTypeDto>().ReverseMap();
            CreateMap<VisitType, VisitTypeDto>().ReverseMap();
            #endregion


        }
    }
}
