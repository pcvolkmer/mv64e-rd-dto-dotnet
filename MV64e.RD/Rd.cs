#pragma warning disable CS8765
#pragma warning disable CS8618

namespace MV64e.RD
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Rd
    {
        [JsonProperty("carePlans", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CarePlan> CarePlans { get; set; }

        [JsonProperty("diagnoses", Required = Required.Always)]
        public List<Diagnosis> Diagnoses { get; set; }

        [JsonProperty("episodesOfCare", Required = Required.Always)]
        public List<EpisodeOfCare> EpisodesOfCare { get; set; }

        [JsonProperty("followUps", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<FollowUp> FollowUps { get; set; }

        [JsonProperty("gmfcsStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<GmfcsStatus> GmfcsStatus { get; set; }

        [JsonProperty("hospitalization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Hospitalization Hospitalization { get; set; }

        [JsonProperty("hpoTerms", Required = Required.Always)]
        public List<HpoTerm> HpoTerms { get; set; }

        [JsonProperty("metadata", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MvhMetadata Metadata { get; set; }

        [JsonProperty("ngsReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<NgsReport> NgsReports { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("therapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Therapy> Therapies { get; set; }
    }

    public partial class CarePlan
    {
        [JsonProperty("clinicalManagementRecommendation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClinicalManagementRecommendation ClinicalManagementRecommendation { get; set; }

        [JsonProperty("geneticCounselingRecommended", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeneticCounselingRecommended { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("noSequencingPerformedReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CarePlanNoSequencingPerformedReasonCoding NoSequencingPerformedReason { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("reevaluationRecommended", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReevaluationRecommended { get; set; }

        [JsonProperty("studyEnrollmentRecommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StudyEnrollmentRecommendation> StudyEnrollmentRecommendations { get; set; }

        [JsonProperty("therapyRecommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<TherapyRecommendation> TherapyRecommendations { get; set; }
    }

    public partial class ClinicalManagementRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public ClinicalManagementRecommendationCoding Type { get; set; }
    }

    public partial class Reference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class ClinicalManagementRecommendationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClinicalManagementRecommendationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CarePlanNoSequencingPerformedReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public CarePlanNoSequencingPerformedReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class StudyEnrollmentRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("study", Required = Required.Always)]
        public List<StudyReference> Study { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneAlterationReference> SupportingVariants { get; set; }
    }

    public partial class StudyReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public StudySystem System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class GeneAlterationReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("gene", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Gene { get; set; }

        [JsonProperty("variant", Required = Required.Always)]
        public Reference Variant { get; set; }
    }

    public partial class Coding
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TherapyRecommendation
    {
        [JsonProperty("category", Required = Required.Always)]
        public RdTherapyCategoryCoding Category { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Medication { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneAlterationReference> SupportingVariants { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public RdTherapyCoding Type { get; set; }
    }

    public partial class RdTherapyCategoryCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdTherapyCategoryCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RdTherapyCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdTherapyCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Diagnosis
    {
        [JsonProperty("codes", Required = Required.Always)]
        public List<OrphanetIcdCoding10GmAlphaIdse> Codes { get; set; }

        [JsonProperty("familyControlLevel", Required = Required.Always)]
        public RdDiagnosisFamilyControlLevelCoding FamilyControlLevel { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("missingCodeReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RdDiagnosisMissingCodeReasonCoding MissingCodeReason { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("onsetDate", Required = Required.Always)]
        public DateTimeOffset OnsetDate { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("recordedOn", Required = Required.Always)]
        public DateTimeOffset RecordedOn { get; set; }

        [JsonProperty("verificationStatus", Required = Required.Always)]
        public RdDiagnosisVerificationStatusCoding VerificationStatus { get; set; }
    }

    public partial class OrphanetIcdCoding10GmAlphaIdse
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public CodeSystem System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RdDiagnosisFamilyControlLevelCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdDiagnosisFamilyControlLevelCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RdDiagnosisMissingCodeReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdDiagnosisMissingCodeReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RdDiagnosisVerificationStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdDiagnosisVerificationStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class EpisodeOfCare
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.Always)]
        public PeriodDate Period { get; set; }
    }

    public partial class PeriodDate
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public DateTimeOffset Start { get; set; }
    }

    public partial class FollowUp
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("lastContactDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastContactDate { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("patientStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public FollowUpPatientStatusCoding PatientStatus { get; set; }
    }

    public partial class FollowUpPatientStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public FollowUpPatientStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class GmfcsStatus
    {
        [JsonProperty("effectiveDate", Required = Required.Always)]
        public DateTimeOffset EffectiveDate { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public GmfcsCoding Value { get; set; }
    }

    public partial class GmfcsCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public GmfcsCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Hospitalization
    {
        [JsonProperty("numberOfDays", Required = Required.Always)]
        public HospitalizationNumberOfDaysCoding NumberOfDays { get; set; }

        [JsonProperty("numberOfStays", Required = Required.Always)]
        public HospitalizationNumberOfStaysCoding NumberOfStays { get; set; }
    }

    public partial class HospitalizationNumberOfDaysCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public HospitalizationNumberOfDaysCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HospitalizationNumberOfStaysCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public HospitalizationNumberOfStaysCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HpoTerm
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("onsetDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OnsetDate { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("recordedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public Coding Value { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<HpoTermStatus> History { get; set; }
    }

    public partial class HpoTermStatus
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public HpoTermStatusCoding Status { get; set; }
    }

    public partial class HpoTermStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public HpoTermStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MvhMetadata
    {
        [JsonProperty("modelProjectConsent", Required = Required.Always)]
        public ModelProjectConsent ModelProjectConsent { get; set; }

        [JsonProperty("researchConsents", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, object>> ResearchConsents { get; set; }

        [JsonProperty("transferTAN", Required = Required.Always)]
        public string TransferTan { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public MvhSubmissionType Type { get; set; }
    }

    public partial class ModelProjectConsent
    {
        [JsonProperty("date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("provisions", Required = Required.Always)]
        public List<Provision> Provisions { get; set; }

        [JsonProperty("version", Required = Required.Always)]
        public string Version { get; set; }
    }

    public partial class Provision
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("purpose", Required = Required.Always)]
        public ModelProjectConsentPurpose Purpose { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public ConsentProvision Type { get; set; }
    }

    public partial class NgsReport
    {
        [JsonProperty("conclusion", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RdNgsReportConclusionCoding Conclusion { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("results", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }

        [JsonProperty("sequencingInfo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public SequencingInfo SequencingInfo { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public NgsReportCoding Type { get; set; }
    }

    public partial class RdNgsReportConclusionCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RdNgsReportConclusionCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("autozygosity", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Autozygosity Autozygosity { get; set; }

        [JsonProperty("copyNumberVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CopyNumberVariant> CopyNumberVariants { get; set; }

        [JsonProperty("smallVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SmallVariant> SmallVariants { get; set; }

        [JsonProperty("structuralVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StructuralVariant> StructuralVariants { get; set; }
    }

    public partial class Autozygosity
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class CopyNumberVariant
    {
        [JsonProperty("acmgClass", Required = Required.Always)]
        public AcmgClassCoding AcmgClass { get; set; }

        [JsonProperty("acmgCriteria", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CopyNumberVariantAcmgCriterion> AcmgCriteria { get; set; }

        [JsonProperty("cDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CDnaChange { get; set; }

        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("endPosition", Required = Required.Always)]
        public long EndPosition { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CopyNumberVariantExternalId> ExternalIds { get; set; }

        [JsonProperty("gDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string GDnaChange { get; set; }

        [JsonProperty("genes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Genes { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("modeOfInheritance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantModeOfInheritanceCoding ModeOfInheritance { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("proteinChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinChange { get; set; }

        [JsonProperty("publications", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationReference> Publications { get; set; }

        [JsonProperty("segregationAnalysis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSegregationAnalysisCoding SegregationAnalysis { get; set; }

        [JsonProperty("significance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSignificanceCoding Significance { get; set; }

        [JsonProperty("startPosition", Required = Required.Always)]
        public long StartPosition { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public CopyNumberVariantCoding Type { get; set; }

        [JsonProperty("zygosity", Required = Required.Always)]
        public VariantZygosityCoding Zygosity { get; set; }
    }

    public partial class AcmgClassCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public AcmgClassCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CopyNumberVariantAcmgCriterion
    {
        [JsonProperty("modifier", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public AcmgCriterionModifierCoding Modifier { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public AcmgCriterionCoding Value { get; set; }
    }

    public partial class AcmgCriterionModifierCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public AcmgCriterionModifierCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class AcmgCriterionCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public AcmgCriterionCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CopyNumberVariantExternalId
    {
        [JsonProperty("system", Required = Required.Always)]
        public Uri System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class BaseVariantLocalizationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public BaseVariantLocalizationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class VariantModeOfInheritanceCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VariantModeOfInheritanceCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class PublicationReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public PublicationSystem System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class VariantSegregationAnalysisCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VariantSegregationAnalysisCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class VariantSignificanceCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VariantSignificanceCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CopyNumberVariantCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public CopyNumberVariantCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class VariantZygosityCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VariantZygosityCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class SmallVariant
    {
        [JsonProperty("acmgClass", Required = Required.Always)]
        public AcmgClassCoding AcmgClass { get; set; }

        [JsonProperty("acmgCriteria", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SmallVariantAcmgCriterion> AcmgCriteria { get; set; }

        [JsonProperty("alt", Required = Required.Always)]
        public string Alt { get; set; }

        [JsonProperty("cDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CDnaChange { get; set; }

        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SmallVariantExternalId> ExternalIds { get; set; }

        [JsonProperty("gDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string GDnaChange { get; set; }

        [JsonProperty("genes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Genes { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("modeOfInheritance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantModeOfInheritanceCoding ModeOfInheritance { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public long Position { get; set; }

        [JsonProperty("proteinChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinChange { get; set; }

        [JsonProperty("publications", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationReference> Publications { get; set; }

        [JsonProperty("ref", Required = Required.Always)]
        public string Ref { get; set; }

        [JsonProperty("segregationAnalysis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSegregationAnalysisCoding SegregationAnalysis { get; set; }

        [JsonProperty("significance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSignificanceCoding Significance { get; set; }

        [JsonProperty("zygosity", Required = Required.Always)]
        public VariantZygosityCoding Zygosity { get; set; }
    }

    public partial class SmallVariantAcmgCriterion
    {
        [JsonProperty("modifier", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public AcmgCriterionModifierCoding Modifier { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public AcmgCriterionCoding Value { get; set; }
    }

    public partial class SmallVariantExternalId
    {
        [JsonProperty("system", Required = Required.Always)]
        public Uri System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class StructuralVariant
    {
        [JsonProperty("acmgClass", Required = Required.Always)]
        public AcmgClassCoding AcmgClass { get; set; }

        [JsonProperty("acmgCriteria", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StructuralVariantAcmgCriterion> AcmgCriteria { get; set; }

        [JsonProperty("cDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CDnaChange { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StructuralVariantExternalId> ExternalIds { get; set; }

        [JsonProperty("gDNAChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string GDnaChange { get; set; }

        [JsonProperty("genes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Genes { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("iscnDescription", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string IscnDescription { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("modeOfInheritance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantModeOfInheritanceCoding ModeOfInheritance { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("proteinChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinChange { get; set; }

        [JsonProperty("publications", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationReference> Publications { get; set; }

        [JsonProperty("segregationAnalysis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSegregationAnalysisCoding SegregationAnalysis { get; set; }

        [JsonProperty("significance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VariantSignificanceCoding Significance { get; set; }

        [JsonProperty("zygosity", Required = Required.Always)]
        public VariantZygosityCoding Zygosity { get; set; }
    }

    public partial class StructuralVariantAcmgCriterion
    {
        [JsonProperty("modifier", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public AcmgCriterionModifierCoding Modifier { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public AcmgCriterionCoding Value { get; set; }
    }

    public partial class StructuralVariantExternalId
    {
        [JsonProperty("system", Required = Required.Always)]
        public Uri System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class SequencingInfo
    {
        [JsonProperty("kit", Required = Required.Always)]
        public string Kit { get; set; }

        [JsonProperty("platform", Required = Required.Always)]
        public NgsReportPlatformCoding Platform { get; set; }
    }

    public partial class NgsReportPlatformCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public NgsReportPlatformCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class NgsReportCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public NgsReportCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Patient
    {
        [JsonProperty("address", Required = Required.Always)]
        public Address Address { get; set; }

        [JsonProperty("age", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Age Age { get; set; }

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("dateOfDeath", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfDeath { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public GenderCoding Gender { get; set; }

        [JsonProperty("healthInsurance", Required = Required.Always)]
        public HealthInsurance HealthInsurance { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("managingSite", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding ManagingSite { get; set; }

        [JsonProperty("vitalStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VitalStatusCoding VitalStatus { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("municipalityCode", Required = Required.Always)]
        public string MunicipalityCode { get; set; }
    }

    public partial class Age
    {
        [JsonProperty("unit", Required = Required.Always)]
        public Unit Unit { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class GenderCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public GenderCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HealthInsurance
    {
        [JsonProperty("reference", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reference { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public HealthInsuranceCoding Type { get; set; }
    }

    public partial class HealthInsuranceCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public HealthInsuranceCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class VitalStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VitalStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Therapy
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<HistoryElement> History { get; set; }
    }

    public partial class HistoryElement
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference BasedOn { get; set; }

        [JsonProperty("category", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RdTherapyCategoryCoding Category { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Medication { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodDate Period { get; set; }

        [JsonProperty("recordedOn", Required = Required.Always)]
        public DateTimeOffset RecordedOn { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RdTherapyCoding Type { get; set; }
    }

    public enum ClinicalManagementRecommendationCodingCode { DiseaseSpecificAmbulatoryCare, Gp, LocalCrd, OtherAmbulatoryCare, OtherCrd, Specialist, UniversityAmbulatoryCare };

    public enum CarePlanNoSequencingPerformedReasonCodingCode { NonGeneticCause, NotRareDisease, Other, Psychosomatic, TargetedDiagnosticsRecommended };

    public enum StudySystem { Drks, Eudamed, EudraCt, Nct };

    public enum RdTherapyCategoryCodingCode { Causal, Symptomatic };

    public enum RdTherapyCodingCode { Combination, EarlyDetection, Genetic, Nutrition, Other, PreventionMedication, Prophylactic, SystemicMedication, TargetedMedication };

    public enum CodeSystem { FhirDeCodeSystemBfarmIcd10Gm, BfarmDeDeKodiersystemeTerminologienAlphaIdSe, OrphaNet };

    public enum RdDiagnosisFamilyControlLevelCodingCode { DuoGenome, SingleGenome, TrioGenome };

    public enum RdDiagnosisMissingCodeReasonCodingCode { NoMatchingCode };

    public enum RdDiagnosisVerificationStatusCodingCode { Confirmed, Partial, Provisional, Unconfirmed };

    public enum FollowUpPatientStatusCodingCode { LostToFu };

    public enum GmfcsCodingCode { I, Ii, Iii, Iv, V };

    public enum HospitalizationNumberOfDaysCodingCode { None, OverFifty, Unknown, UpToFifty, UpToFive, UpToFifteen };

    public enum HospitalizationNumberOfStaysCodingCode { None, OverFifteen, Unknown, UpToFifteen, UpToFive, UpToTen };

    public enum HpoTermStatusCodingCode { Abated, Degraded, Improved, Unchanged };

    public enum ModelProjectConsentPurpose { CaseIdentification, Reidentification, Sequencing };

    public enum ConsentProvision { Deny, Permit };

    public enum MvhSubmissionType { Addition, Correction, Followup, Initial };

    public enum RdNgsReportConclusionCodingCode { NoPathogenicVariantDetected, PartialPhenotype, StructuralVariantWithUnclearBreakpoint, UnclearVariantInDisease };

    public enum AcmgClassCodingCode { Code1, Code2, Code3, Code4, Code5 };

    public enum AcmgCriterionModifierCodingCode { Ba, Bm, Bp, Bs, Pm, Pp, Ps, Pvs };

    public enum AcmgCriterionCodingCode { Ba1, Bp1, Bp2, Bp3, Bp4, Bp5, Bp6, Bp7, Bs1, Bs2, Bs3, Bs4, Pm1, Pm2, Pm3, Pm4, Pm5, Pm6, Pp1, Pp2, Pp3, Pp4, Pp5, Ps1, Ps2, Ps3, Ps4, Pvs1 };

    public enum Chromosome { Chr1, Chr10, Chr11, Chr12, Chr13, Chr14, Chr15, Chr16, Chr17, Chr18, Chr19, Chr2, Chr20, Chr21, Chr22, Chr3, Chr4, Chr5, Chr6, Chr7, Chr8, Chr9, ChrMt, ChrX, ChrY };

    public enum BaseVariantLocalizationCodingCode { CodingRegion, Intergenic, Intronic, RegulatoryRegion, SplicingRegion };

    public enum VariantModeOfInheritanceCodingCode { Dominant, Mitochondrial, Recessive, Unclear, XLinked };

    public enum PublicationSystem { PubmedNcbiNlmNihGov, DoiOrg };

    public enum VariantSegregationAnalysisCodingCode { DeNovo, FromFather, FromMother, NotPerformed };

    public enum VariantSignificanceCodingCode { Candidate, Incidental, Primary };

    public enum CopyNumberVariantCodingCode { Gain, Loss };

    public enum VariantZygosityCodingCode { CompHet, Hemi, Heteroplasmic, Heterozygous, Homoplasmic, Homozygous };

    public enum NgsReportPlatformCodingCode { Illu, Mgi, Ont, Other, Pacb, Code10Xg, Ug };

    public enum NgsReportCodingCode { Array, Exome, GenomeLongRead, GenomeShortRead, Karyotyping, Other, Panel, Single };

    public enum Unit { Months, Years };

    public enum GenderCodingCode { Female, Male, Other, Unknown };

    public enum HealthInsuranceCodingCode { Bei, Bg, Gkv, Gpv, Pkv, Ppv, Sel, Skt, Soz, Unk };

    public enum VitalStatusCodingCode { Alive, Deceased };

    public partial class Rd
    {
        public static Rd FromJson(string json) => JsonConvert.DeserializeObject<Rd>(json, MV64e.RD.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Rd self) => JsonConvert.SerializeObject(self, MV64e.RD.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            MissingMemberHandling = MissingMemberHandling.Error,
            Converters =
            {
                ClinicalManagementRecommendationCodingCodeConverter.Singleton,
                CarePlanNoSequencingPerformedReasonCodingCodeConverter.Singleton,
                StudySystemConverter.Singleton,
                RdTherapyCategoryCodingCodeConverter.Singleton,
                RdTherapyCodingCodeConverter.Singleton,
                CodeSystemConverter.Singleton,
                RdDiagnosisFamilyControlLevelCodingCodeConverter.Singleton,
                RdDiagnosisMissingCodeReasonCodingCodeConverter.Singleton,
                RdDiagnosisVerificationStatusCodingCodeConverter.Singleton,
                FollowUpPatientStatusCodingCodeConverter.Singleton,
                GmfcsCodingCodeConverter.Singleton,
                HospitalizationNumberOfDaysCodingCodeConverter.Singleton,
                HospitalizationNumberOfStaysCodingCodeConverter.Singleton,
                HpoTermStatusCodingCodeConverter.Singleton,
                ModelProjectConsentPurposeConverter.Singleton,
                ConsentProvisionConverter.Singleton,
                MvhSubmissionTypeConverter.Singleton,
                RdNgsReportConclusionCodingCodeConverter.Singleton,
                AcmgClassCodingCodeConverter.Singleton,
                AcmgCriterionModifierCodingCodeConverter.Singleton,
                AcmgCriterionCodingCodeConverter.Singleton,
                ChromosomeConverter.Singleton,
                BaseVariantLocalizationCodingCodeConverter.Singleton,
                VariantModeOfInheritanceCodingCodeConverter.Singleton,
                PublicationSystemConverter.Singleton,
                VariantSegregationAnalysisCodingCodeConverter.Singleton,
                VariantSignificanceCodingCodeConverter.Singleton,
                CopyNumberVariantCodingCodeConverter.Singleton,
                VariantZygosityCodingCodeConverter.Singleton,
                NgsReportPlatformCodingCodeConverter.Singleton,
                NgsReportCodingCodeConverter.Singleton,
                UnitConverter.Singleton,
                GenderCodingCodeConverter.Singleton,
                HealthInsuranceCodingCodeConverter.Singleton,
                VitalStatusCodingCodeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ClinicalManagementRecommendationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClinicalManagementRecommendationCodingCode) || t == typeof(ClinicalManagementRecommendationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "disease-specific-ambulatory-care":
                    return ClinicalManagementRecommendationCodingCode.DiseaseSpecificAmbulatoryCare;
                case "gp":
                    return ClinicalManagementRecommendationCodingCode.Gp;
                case "local-crd":
                    return ClinicalManagementRecommendationCodingCode.LocalCrd;
                case "other-ambulatory-care":
                    return ClinicalManagementRecommendationCodingCode.OtherAmbulatoryCare;
                case "other-crd":
                    return ClinicalManagementRecommendationCodingCode.OtherCrd;
                case "specialist":
                    return ClinicalManagementRecommendationCodingCode.Specialist;
                case "university-ambulatory-care":
                    return ClinicalManagementRecommendationCodingCode.UniversityAmbulatoryCare;
            }
            throw new Exception("Cannot unmarshal type ClinicalManagementRecommendationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClinicalManagementRecommendationCodingCode)untypedValue;
            switch (value)
            {
                case ClinicalManagementRecommendationCodingCode.DiseaseSpecificAmbulatoryCare:
                    serializer.Serialize(writer, "disease-specific-ambulatory-care");
                    return;
                case ClinicalManagementRecommendationCodingCode.Gp:
                    serializer.Serialize(writer, "gp");
                    return;
                case ClinicalManagementRecommendationCodingCode.LocalCrd:
                    serializer.Serialize(writer, "local-crd");
                    return;
                case ClinicalManagementRecommendationCodingCode.OtherAmbulatoryCare:
                    serializer.Serialize(writer, "other-ambulatory-care");
                    return;
                case ClinicalManagementRecommendationCodingCode.OtherCrd:
                    serializer.Serialize(writer, "other-crd");
                    return;
                case ClinicalManagementRecommendationCodingCode.Specialist:
                    serializer.Serialize(writer, "specialist");
                    return;
                case ClinicalManagementRecommendationCodingCode.UniversityAmbulatoryCare:
                    serializer.Serialize(writer, "university-ambulatory-care");
                    return;
            }
            throw new Exception("Cannot marshal type ClinicalManagementRecommendationCodingCode");
        }

        public static readonly ClinicalManagementRecommendationCodingCodeConverter Singleton = new ClinicalManagementRecommendationCodingCodeConverter();
    }

    internal class CarePlanNoSequencingPerformedReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CarePlanNoSequencingPerformedReasonCodingCode) || t == typeof(CarePlanNoSequencingPerformedReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "non-genetic-cause":
                    return CarePlanNoSequencingPerformedReasonCodingCode.NonGeneticCause;
                case "not-rare-disease":
                    return CarePlanNoSequencingPerformedReasonCodingCode.NotRareDisease;
                case "other":
                    return CarePlanNoSequencingPerformedReasonCodingCode.Other;
                case "psychosomatic":
                    return CarePlanNoSequencingPerformedReasonCodingCode.Psychosomatic;
                case "targeted-diagnostics-recommended":
                    return CarePlanNoSequencingPerformedReasonCodingCode.TargetedDiagnosticsRecommended;
            }
            throw new Exception("Cannot unmarshal type CarePlanNoSequencingPerformedReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CarePlanNoSequencingPerformedReasonCodingCode)untypedValue;
            switch (value)
            {
                case CarePlanNoSequencingPerformedReasonCodingCode.NonGeneticCause:
                    serializer.Serialize(writer, "non-genetic-cause");
                    return;
                case CarePlanNoSequencingPerformedReasonCodingCode.NotRareDisease:
                    serializer.Serialize(writer, "not-rare-disease");
                    return;
                case CarePlanNoSequencingPerformedReasonCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case CarePlanNoSequencingPerformedReasonCodingCode.Psychosomatic:
                    serializer.Serialize(writer, "psychosomatic");
                    return;
                case CarePlanNoSequencingPerformedReasonCodingCode.TargetedDiagnosticsRecommended:
                    serializer.Serialize(writer, "targeted-diagnostics-recommended");
                    return;
            }
            throw new Exception("Cannot marshal type CarePlanNoSequencingPerformedReasonCodingCode");
        }

        public static readonly CarePlanNoSequencingPerformedReasonCodingCodeConverter Singleton = new CarePlanNoSequencingPerformedReasonCodingCodeConverter();
    }

    internal class StudySystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StudySystem) || t == typeof(StudySystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DRKS":
                    return StudySystem.Drks;
                case "EUDAMED":
                    return StudySystem.Eudamed;
                case "Eudra-CT":
                    return StudySystem.EudraCt;
                case "NCT":
                    return StudySystem.Nct;
            }
            throw new Exception("Cannot unmarshal type StudySystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StudySystem)untypedValue;
            switch (value)
            {
                case StudySystem.Drks:
                    serializer.Serialize(writer, "DRKS");
                    return;
                case StudySystem.Eudamed:
                    serializer.Serialize(writer, "EUDAMED");
                    return;
                case StudySystem.EudraCt:
                    serializer.Serialize(writer, "Eudra-CT");
                    return;
                case StudySystem.Nct:
                    serializer.Serialize(writer, "NCT");
                    return;
            }
            throw new Exception("Cannot marshal type StudySystem");
        }

        public static readonly StudySystemConverter Singleton = new StudySystemConverter();
    }

    internal class RdTherapyCategoryCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdTherapyCategoryCodingCode) || t == typeof(RdTherapyCategoryCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "causal":
                    return RdTherapyCategoryCodingCode.Causal;
                case "symptomatic":
                    return RdTherapyCategoryCodingCode.Symptomatic;
            }
            throw new Exception("Cannot unmarshal type RdTherapyCategoryCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdTherapyCategoryCodingCode)untypedValue;
            switch (value)
            {
                case RdTherapyCategoryCodingCode.Causal:
                    serializer.Serialize(writer, "causal");
                    return;
                case RdTherapyCategoryCodingCode.Symptomatic:
                    serializer.Serialize(writer, "symptomatic");
                    return;
            }
            throw new Exception("Cannot marshal type RdTherapyCategoryCodingCode");
        }

        public static readonly RdTherapyCategoryCodingCodeConverter Singleton = new RdTherapyCategoryCodingCodeConverter();
    }

    internal class RdTherapyCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdTherapyCodingCode) || t == typeof(RdTherapyCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "combination":
                    return RdTherapyCodingCode.Combination;
                case "early-detection":
                    return RdTherapyCodingCode.EarlyDetection;
                case "genetic":
                    return RdTherapyCodingCode.Genetic;
                case "nutrition":
                    return RdTherapyCodingCode.Nutrition;
                case "other":
                    return RdTherapyCodingCode.Other;
                case "prevention-medication":
                    return RdTherapyCodingCode.PreventionMedication;
                case "prophylactic":
                    return RdTherapyCodingCode.Prophylactic;
                case "systemic-medication":
                    return RdTherapyCodingCode.SystemicMedication;
                case "targeted-medication":
                    return RdTherapyCodingCode.TargetedMedication;
            }
            throw new Exception("Cannot unmarshal type RdTherapyCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdTherapyCodingCode)untypedValue;
            switch (value)
            {
                case RdTherapyCodingCode.Combination:
                    serializer.Serialize(writer, "combination");
                    return;
                case RdTherapyCodingCode.EarlyDetection:
                    serializer.Serialize(writer, "early-detection");
                    return;
                case RdTherapyCodingCode.Genetic:
                    serializer.Serialize(writer, "genetic");
                    return;
                case RdTherapyCodingCode.Nutrition:
                    serializer.Serialize(writer, "nutrition");
                    return;
                case RdTherapyCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case RdTherapyCodingCode.PreventionMedication:
                    serializer.Serialize(writer, "prevention-medication");
                    return;
                case RdTherapyCodingCode.Prophylactic:
                    serializer.Serialize(writer, "prophylactic");
                    return;
                case RdTherapyCodingCode.SystemicMedication:
                    serializer.Serialize(writer, "systemic-medication");
                    return;
                case RdTherapyCodingCode.TargetedMedication:
                    serializer.Serialize(writer, "targeted-medication");
                    return;
            }
            throw new Exception("Cannot marshal type RdTherapyCodingCode");
        }

        public static readonly RdTherapyCodingCodeConverter Singleton = new RdTherapyCodingCodeConverter();
    }

    internal class CodeSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CodeSystem) || t == typeof(CodeSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "http://fhir.de/CodeSystem/bfarm/icd-10-gm":
                    return CodeSystem.FhirDeCodeSystemBfarmIcd10Gm;
                case "https://www.bfarm.de/DE/Kodiersysteme/Terminologien/Alpha-ID-SE":
                    return CodeSystem.BfarmDeDeKodiersystemeTerminologienAlphaIdSe;
                case "https://www.orpha.net":
                    return CodeSystem.OrphaNet;
            }
            throw new Exception("Cannot unmarshal type CodeSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CodeSystem)untypedValue;
            switch (value)
            {
                case CodeSystem.FhirDeCodeSystemBfarmIcd10Gm:
                    serializer.Serialize(writer, "http://fhir.de/CodeSystem/bfarm/icd-10-gm");
                    return;
                case CodeSystem.BfarmDeDeKodiersystemeTerminologienAlphaIdSe:
                    serializer.Serialize(writer, "https://www.bfarm.de/DE/Kodiersysteme/Terminologien/Alpha-ID-SE");
                    return;
                case CodeSystem.OrphaNet:
                    serializer.Serialize(writer, "https://www.orpha.net");
                    return;
            }
            throw new Exception("Cannot marshal type CodeSystem");
        }

        public static readonly CodeSystemConverter Singleton = new CodeSystemConverter();
    }

    internal class RdDiagnosisFamilyControlLevelCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdDiagnosisFamilyControlLevelCodingCode) || t == typeof(RdDiagnosisFamilyControlLevelCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "duo-genome":
                    return RdDiagnosisFamilyControlLevelCodingCode.DuoGenome;
                case "single-genome":
                    return RdDiagnosisFamilyControlLevelCodingCode.SingleGenome;
                case "trio-genome":
                    return RdDiagnosisFamilyControlLevelCodingCode.TrioGenome;
            }
            throw new Exception("Cannot unmarshal type RdDiagnosisFamilyControlLevelCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdDiagnosisFamilyControlLevelCodingCode)untypedValue;
            switch (value)
            {
                case RdDiagnosisFamilyControlLevelCodingCode.DuoGenome:
                    serializer.Serialize(writer, "duo-genome");
                    return;
                case RdDiagnosisFamilyControlLevelCodingCode.SingleGenome:
                    serializer.Serialize(writer, "single-genome");
                    return;
                case RdDiagnosisFamilyControlLevelCodingCode.TrioGenome:
                    serializer.Serialize(writer, "trio-genome");
                    return;
            }
            throw new Exception("Cannot marshal type RdDiagnosisFamilyControlLevelCodingCode");
        }

        public static readonly RdDiagnosisFamilyControlLevelCodingCodeConverter Singleton = new RdDiagnosisFamilyControlLevelCodingCodeConverter();
    }

    internal class RdDiagnosisMissingCodeReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdDiagnosisMissingCodeReasonCodingCode) || t == typeof(RdDiagnosisMissingCodeReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "no-matching-code")
            {
                return RdDiagnosisMissingCodeReasonCodingCode.NoMatchingCode;
            }
            throw new Exception("Cannot unmarshal type RdDiagnosisMissingCodeReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdDiagnosisMissingCodeReasonCodingCode)untypedValue;
            if (value == RdDiagnosisMissingCodeReasonCodingCode.NoMatchingCode)
            {
                serializer.Serialize(writer, "no-matching-code");
                return;
            }
            throw new Exception("Cannot marshal type RdDiagnosisMissingCodeReasonCodingCode");
        }

        public static readonly RdDiagnosisMissingCodeReasonCodingCodeConverter Singleton = new RdDiagnosisMissingCodeReasonCodingCodeConverter();
    }

    internal class RdDiagnosisVerificationStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdDiagnosisVerificationStatusCodingCode) || t == typeof(RdDiagnosisVerificationStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "confirmed":
                    return RdDiagnosisVerificationStatusCodingCode.Confirmed;
                case "partial":
                    return RdDiagnosisVerificationStatusCodingCode.Partial;
                case "provisional":
                    return RdDiagnosisVerificationStatusCodingCode.Provisional;
                case "unconfirmed":
                    return RdDiagnosisVerificationStatusCodingCode.Unconfirmed;
            }
            throw new Exception("Cannot unmarshal type RdDiagnosisVerificationStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdDiagnosisVerificationStatusCodingCode)untypedValue;
            switch (value)
            {
                case RdDiagnosisVerificationStatusCodingCode.Confirmed:
                    serializer.Serialize(writer, "confirmed");
                    return;
                case RdDiagnosisVerificationStatusCodingCode.Partial:
                    serializer.Serialize(writer, "partial");
                    return;
                case RdDiagnosisVerificationStatusCodingCode.Provisional:
                    serializer.Serialize(writer, "provisional");
                    return;
                case RdDiagnosisVerificationStatusCodingCode.Unconfirmed:
                    serializer.Serialize(writer, "unconfirmed");
                    return;
            }
            throw new Exception("Cannot marshal type RdDiagnosisVerificationStatusCodingCode");
        }

        public static readonly RdDiagnosisVerificationStatusCodingCodeConverter Singleton = new RdDiagnosisVerificationStatusCodingCodeConverter();
    }

    internal class FollowUpPatientStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FollowUpPatientStatusCodingCode) || t == typeof(FollowUpPatientStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "lost-to-fu")
            {
                return FollowUpPatientStatusCodingCode.LostToFu;
            }
            throw new Exception("Cannot unmarshal type FollowUpPatientStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FollowUpPatientStatusCodingCode)untypedValue;
            if (value == FollowUpPatientStatusCodingCode.LostToFu)
            {
                serializer.Serialize(writer, "lost-to-fu");
                return;
            }
            throw new Exception("Cannot marshal type FollowUpPatientStatusCodingCode");
        }

        public static readonly FollowUpPatientStatusCodingCodeConverter Singleton = new FollowUpPatientStatusCodingCodeConverter();
    }

    internal class GmfcsCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GmfcsCodingCode) || t == typeof(GmfcsCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "I":
                    return GmfcsCodingCode.I;
                case "II":
                    return GmfcsCodingCode.Ii;
                case "III":
                    return GmfcsCodingCode.Iii;
                case "IV":
                    return GmfcsCodingCode.Iv;
                case "V":
                    return GmfcsCodingCode.V;
            }
            throw new Exception("Cannot unmarshal type GmfcsCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GmfcsCodingCode)untypedValue;
            switch (value)
            {
                case GmfcsCodingCode.I:
                    serializer.Serialize(writer, "I");
                    return;
                case GmfcsCodingCode.Ii:
                    serializer.Serialize(writer, "II");
                    return;
                case GmfcsCodingCode.Iii:
                    serializer.Serialize(writer, "III");
                    return;
                case GmfcsCodingCode.Iv:
                    serializer.Serialize(writer, "IV");
                    return;
                case GmfcsCodingCode.V:
                    serializer.Serialize(writer, "V");
                    return;
            }
            throw new Exception("Cannot marshal type GmfcsCodingCode");
        }

        public static readonly GmfcsCodingCodeConverter Singleton = new GmfcsCodingCodeConverter();
    }

    internal class HospitalizationNumberOfDaysCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HospitalizationNumberOfDaysCodingCode) || t == typeof(HospitalizationNumberOfDaysCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "none":
                    return HospitalizationNumberOfDaysCodingCode.None;
                case "over-fifty":
                    return HospitalizationNumberOfDaysCodingCode.OverFifty;
                case "unknown":
                    return HospitalizationNumberOfDaysCodingCode.Unknown;
                case "up-to-fifty":
                    return HospitalizationNumberOfDaysCodingCode.UpToFifty;
                case "up-to-five":
                    return HospitalizationNumberOfDaysCodingCode.UpToFive;
                case "up-to-fifteen":
                    return HospitalizationNumberOfDaysCodingCode.UpToFifteen;
            }
            throw new Exception("Cannot unmarshal type HospitalizationNumberOfDaysCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HospitalizationNumberOfDaysCodingCode)untypedValue;
            switch (value)
            {
                case HospitalizationNumberOfDaysCodingCode.None:
                    serializer.Serialize(writer, "none");
                    return;
                case HospitalizationNumberOfDaysCodingCode.OverFifty:
                    serializer.Serialize(writer, "over-fifty");
                    return;
                case HospitalizationNumberOfDaysCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
                case HospitalizationNumberOfDaysCodingCode.UpToFifty:
                    serializer.Serialize(writer, "up-to-fifty");
                    return;
                case HospitalizationNumberOfDaysCodingCode.UpToFive:
                    serializer.Serialize(writer, "up-to-five");
                    return;
                case HospitalizationNumberOfDaysCodingCode.UpToFifteen:
                    serializer.Serialize(writer, "up-to-fifteen");
                    return;
            }
            throw new Exception("Cannot marshal type HospitalizationNumberOfDaysCodingCode");
        }

        public static readonly HospitalizationNumberOfDaysCodingCodeConverter Singleton = new HospitalizationNumberOfDaysCodingCodeConverter();
    }

    internal class HospitalizationNumberOfStaysCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HospitalizationNumberOfStaysCodingCode) || t == typeof(HospitalizationNumberOfStaysCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "none":
                    return HospitalizationNumberOfStaysCodingCode.None;
                case "over-fifteen":
                    return HospitalizationNumberOfStaysCodingCode.OverFifteen;
                case "unknown":
                    return HospitalizationNumberOfStaysCodingCode.Unknown;
                case "up-to-fifteen":
                    return HospitalizationNumberOfStaysCodingCode.UpToFifteen;
                case "up-to-five":
                    return HospitalizationNumberOfStaysCodingCode.UpToFive;
                case "up-to-ten":
                    return HospitalizationNumberOfStaysCodingCode.UpToTen;
            }
            throw new Exception("Cannot unmarshal type HospitalizationNumberOfStaysCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HospitalizationNumberOfStaysCodingCode)untypedValue;
            switch (value)
            {
                case HospitalizationNumberOfStaysCodingCode.None:
                    serializer.Serialize(writer, "none");
                    return;
                case HospitalizationNumberOfStaysCodingCode.OverFifteen:
                    serializer.Serialize(writer, "over-fifteen");
                    return;
                case HospitalizationNumberOfStaysCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
                case HospitalizationNumberOfStaysCodingCode.UpToFifteen:
                    serializer.Serialize(writer, "up-to-fifteen");
                    return;
                case HospitalizationNumberOfStaysCodingCode.UpToFive:
                    serializer.Serialize(writer, "up-to-five");
                    return;
                case HospitalizationNumberOfStaysCodingCode.UpToTen:
                    serializer.Serialize(writer, "up-to-ten");
                    return;
            }
            throw new Exception("Cannot marshal type HospitalizationNumberOfStaysCodingCode");
        }

        public static readonly HospitalizationNumberOfStaysCodingCodeConverter Singleton = new HospitalizationNumberOfStaysCodingCodeConverter();
    }

    internal class HpoTermStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HpoTermStatusCodingCode) || t == typeof(HpoTermStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "abated":
                    return HpoTermStatusCodingCode.Abated;
                case "degraded":
                    return HpoTermStatusCodingCode.Degraded;
                case "improved":
                    return HpoTermStatusCodingCode.Improved;
                case "unchanged":
                    return HpoTermStatusCodingCode.Unchanged;
            }
            throw new Exception("Cannot unmarshal type HpoTermStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HpoTermStatusCodingCode)untypedValue;
            switch (value)
            {
                case HpoTermStatusCodingCode.Abated:
                    serializer.Serialize(writer, "abated");
                    return;
                case HpoTermStatusCodingCode.Degraded:
                    serializer.Serialize(writer, "degraded");
                    return;
                case HpoTermStatusCodingCode.Improved:
                    serializer.Serialize(writer, "improved");
                    return;
                case HpoTermStatusCodingCode.Unchanged:
                    serializer.Serialize(writer, "unchanged");
                    return;
            }
            throw new Exception("Cannot marshal type HpoTermStatusCodingCode");
        }

        public static readonly HpoTermStatusCodingCodeConverter Singleton = new HpoTermStatusCodingCodeConverter();
    }

    internal class ModelProjectConsentPurposeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ModelProjectConsentPurpose) || t == typeof(ModelProjectConsentPurpose?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "case-identification":
                    return ModelProjectConsentPurpose.CaseIdentification;
                case "reidentification":
                    return ModelProjectConsentPurpose.Reidentification;
                case "sequencing":
                    return ModelProjectConsentPurpose.Sequencing;
            }
            throw new Exception("Cannot unmarshal type ModelProjectConsentPurpose");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ModelProjectConsentPurpose)untypedValue;
            switch (value)
            {
                case ModelProjectConsentPurpose.CaseIdentification:
                    serializer.Serialize(writer, "case-identification");
                    return;
                case ModelProjectConsentPurpose.Reidentification:
                    serializer.Serialize(writer, "reidentification");
                    return;
                case ModelProjectConsentPurpose.Sequencing:
                    serializer.Serialize(writer, "sequencing");
                    return;
            }
            throw new Exception("Cannot marshal type ModelProjectConsentPurpose");
        }

        public static readonly ModelProjectConsentPurposeConverter Singleton = new ModelProjectConsentPurposeConverter();
    }

    internal class ConsentProvisionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConsentProvision) || t == typeof(ConsentProvision?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "deny":
                    return ConsentProvision.Deny;
                case "permit":
                    return ConsentProvision.Permit;
            }
            throw new Exception("Cannot unmarshal type ConsentProvision");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ConsentProvision)untypedValue;
            switch (value)
            {
                case ConsentProvision.Deny:
                    serializer.Serialize(writer, "deny");
                    return;
                case ConsentProvision.Permit:
                    serializer.Serialize(writer, "permit");
                    return;
            }
            throw new Exception("Cannot marshal type ConsentProvision");
        }

        public static readonly ConsentProvisionConverter Singleton = new ConsentProvisionConverter();
    }

    internal class MvhSubmissionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MvhSubmissionType) || t == typeof(MvhSubmissionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "addition":
                    return MvhSubmissionType.Addition;
                case "correction":
                    return MvhSubmissionType.Correction;
                case "followup":
                    return MvhSubmissionType.Followup;
                case "initial":
                    return MvhSubmissionType.Initial;
            }
            throw new Exception("Cannot unmarshal type MvhSubmissionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MvhSubmissionType)untypedValue;
            switch (value)
            {
                case MvhSubmissionType.Addition:
                    serializer.Serialize(writer, "addition");
                    return;
                case MvhSubmissionType.Correction:
                    serializer.Serialize(writer, "correction");
                    return;
                case MvhSubmissionType.Followup:
                    serializer.Serialize(writer, "followup");
                    return;
                case MvhSubmissionType.Initial:
                    serializer.Serialize(writer, "initial");
                    return;
            }
            throw new Exception("Cannot marshal type MvhSubmissionType");
        }

        public static readonly MvhSubmissionTypeConverter Singleton = new MvhSubmissionTypeConverter();
    }

    internal class RdNgsReportConclusionCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RdNgsReportConclusionCodingCode) || t == typeof(RdNgsReportConclusionCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "no-pathogenic-variant-detected":
                    return RdNgsReportConclusionCodingCode.NoPathogenicVariantDetected;
                case "partial-phenotype":
                    return RdNgsReportConclusionCodingCode.PartialPhenotype;
                case "structural-variant-with-unclear-breakpoint":
                    return RdNgsReportConclusionCodingCode.StructuralVariantWithUnclearBreakpoint;
                case "unclear-variant-in-disease":
                    return RdNgsReportConclusionCodingCode.UnclearVariantInDisease;
            }
            throw new Exception("Cannot unmarshal type RdNgsReportConclusionCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RdNgsReportConclusionCodingCode)untypedValue;
            switch (value)
            {
                case RdNgsReportConclusionCodingCode.NoPathogenicVariantDetected:
                    serializer.Serialize(writer, "no-pathogenic-variant-detected");
                    return;
                case RdNgsReportConclusionCodingCode.PartialPhenotype:
                    serializer.Serialize(writer, "partial-phenotype");
                    return;
                case RdNgsReportConclusionCodingCode.StructuralVariantWithUnclearBreakpoint:
                    serializer.Serialize(writer, "structural-variant-with-unclear-breakpoint");
                    return;
                case RdNgsReportConclusionCodingCode.UnclearVariantInDisease:
                    serializer.Serialize(writer, "unclear-variant-in-disease");
                    return;
            }
            throw new Exception("Cannot marshal type RdNgsReportConclusionCodingCode");
        }

        public static readonly RdNgsReportConclusionCodingCodeConverter Singleton = new RdNgsReportConclusionCodingCodeConverter();
    }

    internal class AcmgClassCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AcmgClassCodingCode) || t == typeof(AcmgClassCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1":
                    return AcmgClassCodingCode.Code1;
                case "2":
                    return AcmgClassCodingCode.Code2;
                case "3":
                    return AcmgClassCodingCode.Code3;
                case "4":
                    return AcmgClassCodingCode.Code4;
                case "5":
                    return AcmgClassCodingCode.Code5;
            }
            throw new Exception("Cannot unmarshal type AcmgClassCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AcmgClassCodingCode)untypedValue;
            switch (value)
            {
                case AcmgClassCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case AcmgClassCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case AcmgClassCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case AcmgClassCodingCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
                case AcmgClassCodingCode.Code5:
                    serializer.Serialize(writer, "5");
                    return;
            }
            throw new Exception("Cannot marshal type AcmgClassCodingCode");
        }

        public static readonly AcmgClassCodingCodeConverter Singleton = new AcmgClassCodingCodeConverter();
    }

    internal class AcmgCriterionModifierCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AcmgCriterionModifierCodingCode) || t == typeof(AcmgCriterionModifierCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ba":
                    return AcmgCriterionModifierCodingCode.Ba;
                case "bm":
                    return AcmgCriterionModifierCodingCode.Bm;
                case "bp":
                    return AcmgCriterionModifierCodingCode.Bp;
                case "bs":
                    return AcmgCriterionModifierCodingCode.Bs;
                case "pm":
                    return AcmgCriterionModifierCodingCode.Pm;
                case "pp":
                    return AcmgCriterionModifierCodingCode.Pp;
                case "ps":
                    return AcmgCriterionModifierCodingCode.Ps;
                case "pvs":
                    return AcmgCriterionModifierCodingCode.Pvs;
            }
            throw new Exception("Cannot unmarshal type AcmgCriterionModifierCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AcmgCriterionModifierCodingCode)untypedValue;
            switch (value)
            {
                case AcmgCriterionModifierCodingCode.Ba:
                    serializer.Serialize(writer, "ba");
                    return;
                case AcmgCriterionModifierCodingCode.Bm:
                    serializer.Serialize(writer, "bm");
                    return;
                case AcmgCriterionModifierCodingCode.Bp:
                    serializer.Serialize(writer, "bp");
                    return;
                case AcmgCriterionModifierCodingCode.Bs:
                    serializer.Serialize(writer, "bs");
                    return;
                case AcmgCriterionModifierCodingCode.Pm:
                    serializer.Serialize(writer, "pm");
                    return;
                case AcmgCriterionModifierCodingCode.Pp:
                    serializer.Serialize(writer, "pp");
                    return;
                case AcmgCriterionModifierCodingCode.Ps:
                    serializer.Serialize(writer, "ps");
                    return;
                case AcmgCriterionModifierCodingCode.Pvs:
                    serializer.Serialize(writer, "pvs");
                    return;
            }
            throw new Exception("Cannot marshal type AcmgCriterionModifierCodingCode");
        }

        public static readonly AcmgCriterionModifierCodingCodeConverter Singleton = new AcmgCriterionModifierCodingCodeConverter();
    }

    internal class AcmgCriterionCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AcmgCriterionCodingCode) || t == typeof(AcmgCriterionCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BA1":
                    return AcmgCriterionCodingCode.Ba1;
                case "BP1":
                    return AcmgCriterionCodingCode.Bp1;
                case "BP2":
                    return AcmgCriterionCodingCode.Bp2;
                case "BP3":
                    return AcmgCriterionCodingCode.Bp3;
                case "BP4":
                    return AcmgCriterionCodingCode.Bp4;
                case "BP5":
                    return AcmgCriterionCodingCode.Bp5;
                case "BP6":
                    return AcmgCriterionCodingCode.Bp6;
                case "BP7":
                    return AcmgCriterionCodingCode.Bp7;
                case "BS1":
                    return AcmgCriterionCodingCode.Bs1;
                case "BS2":
                    return AcmgCriterionCodingCode.Bs2;
                case "BS3":
                    return AcmgCriterionCodingCode.Bs3;
                case "BS4":
                    return AcmgCriterionCodingCode.Bs4;
                case "PM1":
                    return AcmgCriterionCodingCode.Pm1;
                case "PM2":
                    return AcmgCriterionCodingCode.Pm2;
                case "PM3":
                    return AcmgCriterionCodingCode.Pm3;
                case "PM4":
                    return AcmgCriterionCodingCode.Pm4;
                case "PM5":
                    return AcmgCriterionCodingCode.Pm5;
                case "PM6":
                    return AcmgCriterionCodingCode.Pm6;
                case "PP1":
                    return AcmgCriterionCodingCode.Pp1;
                case "PP2":
                    return AcmgCriterionCodingCode.Pp2;
                case "PP3":
                    return AcmgCriterionCodingCode.Pp3;
                case "PP4":
                    return AcmgCriterionCodingCode.Pp4;
                case "PP5":
                    return AcmgCriterionCodingCode.Pp5;
                case "PS1":
                    return AcmgCriterionCodingCode.Ps1;
                case "PS2":
                    return AcmgCriterionCodingCode.Ps2;
                case "PS3":
                    return AcmgCriterionCodingCode.Ps3;
                case "PS4":
                    return AcmgCriterionCodingCode.Ps4;
                case "PVS1":
                    return AcmgCriterionCodingCode.Pvs1;
            }
            throw new Exception("Cannot unmarshal type AcmgCriterionCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AcmgCriterionCodingCode)untypedValue;
            switch (value)
            {
                case AcmgCriterionCodingCode.Ba1:
                    serializer.Serialize(writer, "BA1");
                    return;
                case AcmgCriterionCodingCode.Bp1:
                    serializer.Serialize(writer, "BP1");
                    return;
                case AcmgCriterionCodingCode.Bp2:
                    serializer.Serialize(writer, "BP2");
                    return;
                case AcmgCriterionCodingCode.Bp3:
                    serializer.Serialize(writer, "BP3");
                    return;
                case AcmgCriterionCodingCode.Bp4:
                    serializer.Serialize(writer, "BP4");
                    return;
                case AcmgCriterionCodingCode.Bp5:
                    serializer.Serialize(writer, "BP5");
                    return;
                case AcmgCriterionCodingCode.Bp6:
                    serializer.Serialize(writer, "BP6");
                    return;
                case AcmgCriterionCodingCode.Bp7:
                    serializer.Serialize(writer, "BP7");
                    return;
                case AcmgCriterionCodingCode.Bs1:
                    serializer.Serialize(writer, "BS1");
                    return;
                case AcmgCriterionCodingCode.Bs2:
                    serializer.Serialize(writer, "BS2");
                    return;
                case AcmgCriterionCodingCode.Bs3:
                    serializer.Serialize(writer, "BS3");
                    return;
                case AcmgCriterionCodingCode.Bs4:
                    serializer.Serialize(writer, "BS4");
                    return;
                case AcmgCriterionCodingCode.Pm1:
                    serializer.Serialize(writer, "PM1");
                    return;
                case AcmgCriterionCodingCode.Pm2:
                    serializer.Serialize(writer, "PM2");
                    return;
                case AcmgCriterionCodingCode.Pm3:
                    serializer.Serialize(writer, "PM3");
                    return;
                case AcmgCriterionCodingCode.Pm4:
                    serializer.Serialize(writer, "PM4");
                    return;
                case AcmgCriterionCodingCode.Pm5:
                    serializer.Serialize(writer, "PM5");
                    return;
                case AcmgCriterionCodingCode.Pm6:
                    serializer.Serialize(writer, "PM6");
                    return;
                case AcmgCriterionCodingCode.Pp1:
                    serializer.Serialize(writer, "PP1");
                    return;
                case AcmgCriterionCodingCode.Pp2:
                    serializer.Serialize(writer, "PP2");
                    return;
                case AcmgCriterionCodingCode.Pp3:
                    serializer.Serialize(writer, "PP3");
                    return;
                case AcmgCriterionCodingCode.Pp4:
                    serializer.Serialize(writer, "PP4");
                    return;
                case AcmgCriterionCodingCode.Pp5:
                    serializer.Serialize(writer, "PP5");
                    return;
                case AcmgCriterionCodingCode.Ps1:
                    serializer.Serialize(writer, "PS1");
                    return;
                case AcmgCriterionCodingCode.Ps2:
                    serializer.Serialize(writer, "PS2");
                    return;
                case AcmgCriterionCodingCode.Ps3:
                    serializer.Serialize(writer, "PS3");
                    return;
                case AcmgCriterionCodingCode.Ps4:
                    serializer.Serialize(writer, "PS4");
                    return;
                case AcmgCriterionCodingCode.Pvs1:
                    serializer.Serialize(writer, "PVS1");
                    return;
            }
            throw new Exception("Cannot marshal type AcmgCriterionCodingCode");
        }

        public static readonly AcmgCriterionCodingCodeConverter Singleton = new AcmgCriterionCodingCodeConverter();
    }

    internal class ChromosomeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Chromosome) || t == typeof(Chromosome?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "chr1":
                    return Chromosome.Chr1;
                case "chr10":
                    return Chromosome.Chr10;
                case "chr11":
                    return Chromosome.Chr11;
                case "chr12":
                    return Chromosome.Chr12;
                case "chr13":
                    return Chromosome.Chr13;
                case "chr14":
                    return Chromosome.Chr14;
                case "chr15":
                    return Chromosome.Chr15;
                case "chr16":
                    return Chromosome.Chr16;
                case "chr17":
                    return Chromosome.Chr17;
                case "chr18":
                    return Chromosome.Chr18;
                case "chr19":
                    return Chromosome.Chr19;
                case "chr2":
                    return Chromosome.Chr2;
                case "chr20":
                    return Chromosome.Chr20;
                case "chr21":
                    return Chromosome.Chr21;
                case "chr22":
                    return Chromosome.Chr22;
                case "chr3":
                    return Chromosome.Chr3;
                case "chr4":
                    return Chromosome.Chr4;
                case "chr5":
                    return Chromosome.Chr5;
                case "chr6":
                    return Chromosome.Chr6;
                case "chr7":
                    return Chromosome.Chr7;
                case "chr8":
                    return Chromosome.Chr8;
                case "chr9":
                    return Chromosome.Chr9;
                case "chrMT":
                    return Chromosome.ChrMt;
                case "chrX":
                    return Chromosome.ChrX;
                case "chrY":
                    return Chromosome.ChrY;
            }
            throw new Exception("Cannot unmarshal type Chromosome");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Chromosome)untypedValue;
            switch (value)
            {
                case Chromosome.Chr1:
                    serializer.Serialize(writer, "chr1");
                    return;
                case Chromosome.Chr10:
                    serializer.Serialize(writer, "chr10");
                    return;
                case Chromosome.Chr11:
                    serializer.Serialize(writer, "chr11");
                    return;
                case Chromosome.Chr12:
                    serializer.Serialize(writer, "chr12");
                    return;
                case Chromosome.Chr13:
                    serializer.Serialize(writer, "chr13");
                    return;
                case Chromosome.Chr14:
                    serializer.Serialize(writer, "chr14");
                    return;
                case Chromosome.Chr15:
                    serializer.Serialize(writer, "chr15");
                    return;
                case Chromosome.Chr16:
                    serializer.Serialize(writer, "chr16");
                    return;
                case Chromosome.Chr17:
                    serializer.Serialize(writer, "chr17");
                    return;
                case Chromosome.Chr18:
                    serializer.Serialize(writer, "chr18");
                    return;
                case Chromosome.Chr19:
                    serializer.Serialize(writer, "chr19");
                    return;
                case Chromosome.Chr2:
                    serializer.Serialize(writer, "chr2");
                    return;
                case Chromosome.Chr20:
                    serializer.Serialize(writer, "chr20");
                    return;
                case Chromosome.Chr21:
                    serializer.Serialize(writer, "chr21");
                    return;
                case Chromosome.Chr22:
                    serializer.Serialize(writer, "chr22");
                    return;
                case Chromosome.Chr3:
                    serializer.Serialize(writer, "chr3");
                    return;
                case Chromosome.Chr4:
                    serializer.Serialize(writer, "chr4");
                    return;
                case Chromosome.Chr5:
                    serializer.Serialize(writer, "chr5");
                    return;
                case Chromosome.Chr6:
                    serializer.Serialize(writer, "chr6");
                    return;
                case Chromosome.Chr7:
                    serializer.Serialize(writer, "chr7");
                    return;
                case Chromosome.Chr8:
                    serializer.Serialize(writer, "chr8");
                    return;
                case Chromosome.Chr9:
                    serializer.Serialize(writer, "chr9");
                    return;
                case Chromosome.ChrMt:
                    serializer.Serialize(writer, "chrMT");
                    return;
                case Chromosome.ChrX:
                    serializer.Serialize(writer, "chrX");
                    return;
                case Chromosome.ChrY:
                    serializer.Serialize(writer, "chrY");
                    return;
            }
            throw new Exception("Cannot marshal type Chromosome");
        }

        public static readonly ChromosomeConverter Singleton = new ChromosomeConverter();
    }

    internal class BaseVariantLocalizationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BaseVariantLocalizationCodingCode) || t == typeof(BaseVariantLocalizationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "coding-region":
                    return BaseVariantLocalizationCodingCode.CodingRegion;
                case "intergenic":
                    return BaseVariantLocalizationCodingCode.Intergenic;
                case "intronic":
                    return BaseVariantLocalizationCodingCode.Intronic;
                case "regulatory-region":
                    return BaseVariantLocalizationCodingCode.RegulatoryRegion;
                case "splicing-region":
                    return BaseVariantLocalizationCodingCode.SplicingRegion;
            }
            throw new Exception("Cannot unmarshal type BaseVariantLocalizationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BaseVariantLocalizationCodingCode)untypedValue;
            switch (value)
            {
                case BaseVariantLocalizationCodingCode.CodingRegion:
                    serializer.Serialize(writer, "coding-region");
                    return;
                case BaseVariantLocalizationCodingCode.Intergenic:
                    serializer.Serialize(writer, "intergenic");
                    return;
                case BaseVariantLocalizationCodingCode.Intronic:
                    serializer.Serialize(writer, "intronic");
                    return;
                case BaseVariantLocalizationCodingCode.RegulatoryRegion:
                    serializer.Serialize(writer, "regulatory-region");
                    return;
                case BaseVariantLocalizationCodingCode.SplicingRegion:
                    serializer.Serialize(writer, "splicing-region");
                    return;
            }
            throw new Exception("Cannot marshal type BaseVariantLocalizationCodingCode");
        }

        public static readonly BaseVariantLocalizationCodingCodeConverter Singleton = new BaseVariantLocalizationCodingCodeConverter();
    }

    internal class VariantModeOfInheritanceCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VariantModeOfInheritanceCodingCode) || t == typeof(VariantModeOfInheritanceCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "X-linked":
                    return VariantModeOfInheritanceCodingCode.XLinked;
                case "dominant":
                    return VariantModeOfInheritanceCodingCode.Dominant;
                case "mitochondrial":
                    return VariantModeOfInheritanceCodingCode.Mitochondrial;
                case "recessive":
                    return VariantModeOfInheritanceCodingCode.Recessive;
                case "unclear":
                    return VariantModeOfInheritanceCodingCode.Unclear;
            }
            throw new Exception("Cannot unmarshal type VariantModeOfInheritanceCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VariantModeOfInheritanceCodingCode)untypedValue;
            switch (value)
            {
                case VariantModeOfInheritanceCodingCode.XLinked:
                    serializer.Serialize(writer, "X-linked");
                    return;
                case VariantModeOfInheritanceCodingCode.Dominant:
                    serializer.Serialize(writer, "dominant");
                    return;
                case VariantModeOfInheritanceCodingCode.Mitochondrial:
                    serializer.Serialize(writer, "mitochondrial");
                    return;
                case VariantModeOfInheritanceCodingCode.Recessive:
                    serializer.Serialize(writer, "recessive");
                    return;
                case VariantModeOfInheritanceCodingCode.Unclear:
                    serializer.Serialize(writer, "unclear");
                    return;
            }
            throw new Exception("Cannot marshal type VariantModeOfInheritanceCodingCode");
        }

        public static readonly VariantModeOfInheritanceCodingCodeConverter Singleton = new VariantModeOfInheritanceCodingCodeConverter();
    }

    internal class PublicationSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PublicationSystem) || t == typeof(PublicationSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://pubmed.ncbi.nlm.nih.gov":
                    return PublicationSystem.PubmedNcbiNlmNihGov;
                case "https://www.doi.org":
                    return PublicationSystem.DoiOrg;
            }
            throw new Exception("Cannot unmarshal type PublicationSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PublicationSystem)untypedValue;
            switch (value)
            {
                case PublicationSystem.PubmedNcbiNlmNihGov:
                    serializer.Serialize(writer, "https://pubmed.ncbi.nlm.nih.gov");
                    return;
                case PublicationSystem.DoiOrg:
                    serializer.Serialize(writer, "https://www.doi.org");
                    return;
            }
            throw new Exception("Cannot marshal type PublicationSystem");
        }

        public static readonly PublicationSystemConverter Singleton = new PublicationSystemConverter();
    }

    internal class VariantSegregationAnalysisCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VariantSegregationAnalysisCodingCode) || t == typeof(VariantSegregationAnalysisCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "de-novo":
                    return VariantSegregationAnalysisCodingCode.DeNovo;
                case "from-father":
                    return VariantSegregationAnalysisCodingCode.FromFather;
                case "from-mother":
                    return VariantSegregationAnalysisCodingCode.FromMother;
                case "not-performed":
                    return VariantSegregationAnalysisCodingCode.NotPerformed;
            }
            throw new Exception("Cannot unmarshal type VariantSegregationAnalysisCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VariantSegregationAnalysisCodingCode)untypedValue;
            switch (value)
            {
                case VariantSegregationAnalysisCodingCode.DeNovo:
                    serializer.Serialize(writer, "de-novo");
                    return;
                case VariantSegregationAnalysisCodingCode.FromFather:
                    serializer.Serialize(writer, "from-father");
                    return;
                case VariantSegregationAnalysisCodingCode.FromMother:
                    serializer.Serialize(writer, "from-mother");
                    return;
                case VariantSegregationAnalysisCodingCode.NotPerformed:
                    serializer.Serialize(writer, "not-performed");
                    return;
            }
            throw new Exception("Cannot marshal type VariantSegregationAnalysisCodingCode");
        }

        public static readonly VariantSegregationAnalysisCodingCodeConverter Singleton = new VariantSegregationAnalysisCodingCodeConverter();
    }

    internal class VariantSignificanceCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VariantSignificanceCodingCode) || t == typeof(VariantSignificanceCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "candidate":
                    return VariantSignificanceCodingCode.Candidate;
                case "incidental":
                    return VariantSignificanceCodingCode.Incidental;
                case "primary":
                    return VariantSignificanceCodingCode.Primary;
            }
            throw new Exception("Cannot unmarshal type VariantSignificanceCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VariantSignificanceCodingCode)untypedValue;
            switch (value)
            {
                case VariantSignificanceCodingCode.Candidate:
                    serializer.Serialize(writer, "candidate");
                    return;
                case VariantSignificanceCodingCode.Incidental:
                    serializer.Serialize(writer, "incidental");
                    return;
                case VariantSignificanceCodingCode.Primary:
                    serializer.Serialize(writer, "primary");
                    return;
            }
            throw new Exception("Cannot marshal type VariantSignificanceCodingCode");
        }

        public static readonly VariantSignificanceCodingCodeConverter Singleton = new VariantSignificanceCodingCodeConverter();
    }

    internal class CopyNumberVariantCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CopyNumberVariantCodingCode) || t == typeof(CopyNumberVariantCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "gain":
                    return CopyNumberVariantCodingCode.Gain;
                case "loss":
                    return CopyNumberVariantCodingCode.Loss;
            }
            throw new Exception("Cannot unmarshal type CopyNumberVariantCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CopyNumberVariantCodingCode)untypedValue;
            switch (value)
            {
                case CopyNumberVariantCodingCode.Gain:
                    serializer.Serialize(writer, "gain");
                    return;
                case CopyNumberVariantCodingCode.Loss:
                    serializer.Serialize(writer, "loss");
                    return;
            }
            throw new Exception("Cannot marshal type CopyNumberVariantCodingCode");
        }

        public static readonly CopyNumberVariantCodingCodeConverter Singleton = new CopyNumberVariantCodingCodeConverter();
    }

    internal class VariantZygosityCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VariantZygosityCodingCode) || t == typeof(VariantZygosityCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "comp-het":
                    return VariantZygosityCodingCode.CompHet;
                case "hemi":
                    return VariantZygosityCodingCode.Hemi;
                case "heteroplasmic":
                    return VariantZygosityCodingCode.Heteroplasmic;
                case "heterozygous":
                    return VariantZygosityCodingCode.Heterozygous;
                case "homoplasmic":
                    return VariantZygosityCodingCode.Homoplasmic;
                case "homozygous":
                    return VariantZygosityCodingCode.Homozygous;
            }
            throw new Exception("Cannot unmarshal type VariantZygosityCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VariantZygosityCodingCode)untypedValue;
            switch (value)
            {
                case VariantZygosityCodingCode.CompHet:
                    serializer.Serialize(writer, "comp-het");
                    return;
                case VariantZygosityCodingCode.Hemi:
                    serializer.Serialize(writer, "hemi");
                    return;
                case VariantZygosityCodingCode.Heteroplasmic:
                    serializer.Serialize(writer, "heteroplasmic");
                    return;
                case VariantZygosityCodingCode.Heterozygous:
                    serializer.Serialize(writer, "heterozygous");
                    return;
                case VariantZygosityCodingCode.Homoplasmic:
                    serializer.Serialize(writer, "homoplasmic");
                    return;
                case VariantZygosityCodingCode.Homozygous:
                    serializer.Serialize(writer, "homozygous");
                    return;
            }
            throw new Exception("Cannot marshal type VariantZygosityCodingCode");
        }

        public static readonly VariantZygosityCodingCodeConverter Singleton = new VariantZygosityCodingCodeConverter();
    }

    internal class NgsReportPlatformCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NgsReportPlatformCodingCode) || t == typeof(NgsReportPlatformCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "10xg":
                    return NgsReportPlatformCodingCode.Code10Xg;
                case "illu":
                    return NgsReportPlatformCodingCode.Illu;
                case "mgi":
                    return NgsReportPlatformCodingCode.Mgi;
                case "ont":
                    return NgsReportPlatformCodingCode.Ont;
                case "other":
                    return NgsReportPlatformCodingCode.Other;
                case "pacb":
                    return NgsReportPlatformCodingCode.Pacb;
                case "ug":
                    return NgsReportPlatformCodingCode.Ug;
            }
            throw new Exception("Cannot unmarshal type NgsReportPlatformCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NgsReportPlatformCodingCode)untypedValue;
            switch (value)
            {
                case NgsReportPlatformCodingCode.Code10Xg:
                    serializer.Serialize(writer, "10xg");
                    return;
                case NgsReportPlatformCodingCode.Illu:
                    serializer.Serialize(writer, "illu");
                    return;
                case NgsReportPlatformCodingCode.Mgi:
                    serializer.Serialize(writer, "mgi");
                    return;
                case NgsReportPlatformCodingCode.Ont:
                    serializer.Serialize(writer, "ont");
                    return;
                case NgsReportPlatformCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case NgsReportPlatformCodingCode.Pacb:
                    serializer.Serialize(writer, "pacb");
                    return;
                case NgsReportPlatformCodingCode.Ug:
                    serializer.Serialize(writer, "ug");
                    return;
            }
            throw new Exception("Cannot marshal type NgsReportPlatformCodingCode");
        }

        public static readonly NgsReportPlatformCodingCodeConverter Singleton = new NgsReportPlatformCodingCodeConverter();
    }

    internal class NgsReportCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NgsReportCodingCode) || t == typeof(NgsReportCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return NgsReportCodingCode.Array;
                case "exome":
                    return NgsReportCodingCode.Exome;
                case "genome-long-read":
                    return NgsReportCodingCode.GenomeLongRead;
                case "genome-short-read":
                    return NgsReportCodingCode.GenomeShortRead;
                case "karyotyping":
                    return NgsReportCodingCode.Karyotyping;
                case "other":
                    return NgsReportCodingCode.Other;
                case "panel":
                    return NgsReportCodingCode.Panel;
                case "single":
                    return NgsReportCodingCode.Single;
            }
            throw new Exception("Cannot unmarshal type NgsReportCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NgsReportCodingCode)untypedValue;
            switch (value)
            {
                case NgsReportCodingCode.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case NgsReportCodingCode.Exome:
                    serializer.Serialize(writer, "exome");
                    return;
                case NgsReportCodingCode.GenomeLongRead:
                    serializer.Serialize(writer, "genome-long-read");
                    return;
                case NgsReportCodingCode.GenomeShortRead:
                    serializer.Serialize(writer, "genome-short-read");
                    return;
                case NgsReportCodingCode.Karyotyping:
                    serializer.Serialize(writer, "karyotyping");
                    return;
                case NgsReportCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case NgsReportCodingCode.Panel:
                    serializer.Serialize(writer, "panel");
                    return;
                case NgsReportCodingCode.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type NgsReportCodingCode");
        }

        public static readonly NgsReportCodingCodeConverter Singleton = new NgsReportCodingCodeConverter();
    }

    internal class UnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Unit) || t == typeof(Unit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Months":
                    return Unit.Months;
                case "Years":
                    return Unit.Years;
            }
            throw new Exception("Cannot unmarshal type Unit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Unit)untypedValue;
            switch (value)
            {
                case Unit.Months:
                    serializer.Serialize(writer, "Months");
                    return;
                case Unit.Years:
                    serializer.Serialize(writer, "Years");
                    return;
            }
            throw new Exception("Cannot marshal type Unit");
        }

        public static readonly UnitConverter Singleton = new UnitConverter();
    }

    internal class GenderCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GenderCodingCode) || t == typeof(GenderCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return GenderCodingCode.Female;
                case "male":
                    return GenderCodingCode.Male;
                case "other":
                    return GenderCodingCode.Other;
                case "unknown":
                    return GenderCodingCode.Unknown;
            }
            throw new Exception("Cannot unmarshal type GenderCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GenderCodingCode)untypedValue;
            switch (value)
            {
                case GenderCodingCode.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case GenderCodingCode.Male:
                    serializer.Serialize(writer, "male");
                    return;
                case GenderCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case GenderCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type GenderCodingCode");
        }

        public static readonly GenderCodingCodeConverter Singleton = new GenderCodingCodeConverter();
    }

    internal class HealthInsuranceCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HealthInsuranceCodingCode) || t == typeof(HealthInsuranceCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BEI":
                    return HealthInsuranceCodingCode.Bei;
                case "BG":
                    return HealthInsuranceCodingCode.Bg;
                case "GKV":
                    return HealthInsuranceCodingCode.Gkv;
                case "GPV":
                    return HealthInsuranceCodingCode.Gpv;
                case "PKV":
                    return HealthInsuranceCodingCode.Pkv;
                case "PPV":
                    return HealthInsuranceCodingCode.Ppv;
                case "SEL":
                    return HealthInsuranceCodingCode.Sel;
                case "SKT":
                    return HealthInsuranceCodingCode.Skt;
                case "SOZ":
                    return HealthInsuranceCodingCode.Soz;
                case "UNK":
                    return HealthInsuranceCodingCode.Unk;
            }
            throw new Exception("Cannot unmarshal type HealthInsuranceCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HealthInsuranceCodingCode)untypedValue;
            switch (value)
            {
                case HealthInsuranceCodingCode.Bei:
                    serializer.Serialize(writer, "BEI");
                    return;
                case HealthInsuranceCodingCode.Bg:
                    serializer.Serialize(writer, "BG");
                    return;
                case HealthInsuranceCodingCode.Gkv:
                    serializer.Serialize(writer, "GKV");
                    return;
                case HealthInsuranceCodingCode.Gpv:
                    serializer.Serialize(writer, "GPV");
                    return;
                case HealthInsuranceCodingCode.Pkv:
                    serializer.Serialize(writer, "PKV");
                    return;
                case HealthInsuranceCodingCode.Ppv:
                    serializer.Serialize(writer, "PPV");
                    return;
                case HealthInsuranceCodingCode.Sel:
                    serializer.Serialize(writer, "SEL");
                    return;
                case HealthInsuranceCodingCode.Skt:
                    serializer.Serialize(writer, "SKT");
                    return;
                case HealthInsuranceCodingCode.Soz:
                    serializer.Serialize(writer, "SOZ");
                    return;
                case HealthInsuranceCodingCode.Unk:
                    serializer.Serialize(writer, "UNK");
                    return;
            }
            throw new Exception("Cannot marshal type HealthInsuranceCodingCode");
        }

        public static readonly HealthInsuranceCodingCodeConverter Singleton = new HealthInsuranceCodingCodeConverter();
    }

    internal class VitalStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VitalStatusCodingCode) || t == typeof(VitalStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alive":
                    return VitalStatusCodingCode.Alive;
                case "deceased":
                    return VitalStatusCodingCode.Deceased;
            }
            throw new Exception("Cannot unmarshal type VitalStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VitalStatusCodingCode)untypedValue;
            switch (value)
            {
                case VitalStatusCodingCode.Alive:
                    serializer.Serialize(writer, "alive");
                    return;
                case VitalStatusCodingCode.Deceased:
                    serializer.Serialize(writer, "deceased");
                    return;
            }
            throw new Exception("Cannot marshal type VitalStatusCodingCode");
        }

        public static readonly VitalStatusCodingCodeConverter Singleton = new VitalStatusCodingCodeConverter();
    }
}
