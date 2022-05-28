public class BusinessObjectModel 
{
	public string bomTriggerCode { get; set; }
	public string bomTriggerFreeText { get; set; }
	public long bomExecutionDateTime { get; set; }
	public PrescriptionDispense? currentDispense { get; set; }
	public PrescriptionDispenseHistory[]? medicationHistory { get; set; }
	public DecisionDetail[]? cepDecisionDetails { get; set; }
}

public class PrescriptionDispense
{
	public Dispense? dispense { get; set; }
	public PrescriptionHeader? prescriptionHeader { get; set; }
	public Patient? patient { get; set; }
	public CPM? cpm { get; set; }
	public string? requestId { get; set; }
	public string? requestedByService { get; set; }
}

public class Dispense
{
	public string? sourceSystemName { get; set; }
	public string? dispenseCode { get; set; }
	public string? actualProductPackCode { get; set; }
	public long? createDateTime { get; set; }
	public string? dataEnteredBy { get; set; }
	public int? immunizationCurrentDose { get; set; }
	public bool? immunizationToBeAdministered { get; set; }
	public string? immunizationShareWithPCP { get; set; }
	public string? immunizationShareWithPrescriberCode { get; set; }
	public int? daysSupply { get; set; }
	public EncryptedStringField? deletedComment { get; set; }
	public long? deletedDateTime { get; set; }
	public string? deletedReason { get; set; }
	public int? dispenseNumber { get; set; }
	public int? dispenseVersion { get; set; }
	public int? prescriberVersion { get; set; }
	public int? patientVersion { get; set; }
	public string? dispenseCompletionStatus { get; set; }
	public string? locationCode { get; set; }
	public string? intakeChannel { get; set; }
	public string? payCode { get; set; }
	public bool? paymentCashOnly { get; set; }
	public string? pharmacistOfRecord { get; set; }
	public bool? customPayment { get; set; }
	public Plan[]? plans { get; set; }
	public BilledPlan[]? billingPlans { get; set; }
	public float? quantityDispensed { get; set; }
	public EncryptedStringField? rxNumber { get; set; }
	public long? soldDateTime { get; set; }
	public long? updateDatetime { get; set; }
	public string? updatedBy { get; set; }
	public string? updatedFromLocation { get; set; }
	public long? promiseTime { get; set; }
	public string? promiseTimeType { get; set; }
	public bool? emergencySupplyDispense { get; set; }
	public bool? partialFillDispense { get; set; }
	public string? associatedPartialFillDispenseCode { get; set; }
	public string? associatedEmergencySupplyDispenseCode { get; set; }
	public long? ruleDrivenExpirationLimit { get; set; }
	public string? shortFillInd { get; set; }
	public string? satrWOCorrelationCode { get; set; }
	public int? satrRxCount { get; set; }
	public Product? product { get; set; }
	public Location? location { get; set; }
}

public class EncryptedStringField
{
	public string? value { get; set; }
	public string? keyId { get; set; }
}

public class Plan
{
	public string? planCode { get; set; }
	public string? patientPlanType { get; set; }
	public string? planType { get; set; }
	public EncryptedStringField? generalRecipientNumber { get; set; }
	public long? dateOfInjury { get; set; }
	public ThirdPartyAuthorization? thirdPartyAuthorization { get; set; }
}

public class ThirdPartyAuthorization
{
	public TpaDiagnosticCode[]? diagnosticCodes { get; set; }
}

public class TpaDiagnosticCode
{
	public string? diagnosticCode { get; set; }
	public string? diagnosticCodeType { get; set; }
}

public class BilledPlan
{
	public string? planCode { get; set; }
	public string? planType { get; set; }
	public bool? billToCOBIndicator { get; set; }
	public string? binNbr { get; set; }
	public string? prcsCtrlNbr { get; set; }
	public string? planGroupNbr { get; set; }
}

public class Product
{
	public string? gpi { get; set; }
	public string? gtin { get; set; }
	public string? drugId { get; set; }
	public string? billingNdc { get; set; }
	public string? cdsNdc { get; set; }
	public string? ndc { get; set; }
	public string? maintenanceCode { get; set; }
	public string? brandGenericIndicator { get; set; }
	public string? federalDeaClass { get; set; }
	public StateDea[]? statesDeaClassList { get; set; }
	public int? defaultDaysSupply { get; set; }
	public int? daysSinceLastDose { get; set; }
	public string? mylarDescription { get; set; }
	public string? manufacturerName { get; set; }
	public string? manufacturerNameAbbr { get; set; }
	public string? productFullName { get; set; }
	public string? productName { get; set; }
	public bool? eligibleFor90Day { get; set; }
	public bool? vaccineIndicator { get; set; }
}

public class StateDea
{
	public string? stateCode { get; set; }
	public string? deaClass { get; set; }
}

public class Location
{
	public string? locationState { get; set; }
	public string? locationClassificationType { get; set; }
	public string? relocatedFromStoreNumber { get; set; }
	public long? relocatedToLocationOpenDate { get; set; }
	public long? closeDate { get; set; }
}

public class PrescriptionHeader
{
	public string? prescriptionCode { get; set; }
	public string? exceptionCodeReauth { get; set; }
	public EmergencySupply? emergencySupply { get; set; }
	public int? prescriptionVersion { get; set; }
	public EncryptedStringField? rxClosedDeletedComment { get; set; }
	public long? rxClosedDeletedDatetime { get; set; }
	public string? rxClosedDeletedPrimaryReason { get; set; }
	public string? rxClosedDeletedSecondaryReason { get; set; }
	public string? rxStatus { get; set; }
	public EncryptedStringField? specDirection { get; set; }
	public bool? specDispenseAsWritten { get; set; }
	public long? expirationDate { get; set; }
	public string? rxDocumentCode { get; set; }
	public string? locationCode { get; set; }
	public float? specNumberRefill { get; set; }
	public string? intakeChannel { get; set; }
	public long? originalEnteredDateTime { get; set; }
	public float? specOriginalQuantityPrescribed { get; set; }
	public string? specPatientCode { get; set; }
	public string? specPrescribedProduct { get; set; }
	public string? specPrescriberCode { get; set; }
	public string? specPrescriberLegacyCode { get; set; }
	public string? specPrescriberLocationLegacyCode { get; set; }
	public string? specPrescriberDeaNumber { get; set; }
	public string? specPrescriberLocationCode { get; set; }
	public string? substitutePreference { get; set; }
	public float? totalQuantityPrescribed { get; set; }
	public bool? specUnlimitedFill { get; set; }
	public long? specWrittenDate { get; set; }
	public long? specDoNotDispenseBefore { get; set; }
	public bool? autoFill { get; set; }
	public long? autoFillUpdatedDate { get; set; }
	public string? ninetyDayRxPreference { get; set; }
	public long? ninetyDayRxPreferenceDate { get; set; }
	public long? refillDueDate { get; set; }
	public long? refillExpirationDate { get; set; }
	public float? qtyRemaining { get; set; }
	public float? refillsRemaining { get; set; }
	public string? satrConsentInd { get; set; }
	public string? satrEnrollInd { get; set; }
	public long? satrConsentDttm { get; set; }
	public long? satrWithdrawDttm { get; set; }
	public Prescriber? prescriber { get; set; }
	public TransferredFromCompetitor? transferredFromCompetitor { get; set; }
	public TransferredToCompetitor? transferredToCompetitor { get; set; }
	public string? specSupervisingPrescriberCode { get; set; }
	public int? specSupervisingPrescriberVersion { get; set; }
	public string? specSupervisingPrescriberLocationCode { get; set; }
	public string? specSupervisingPrescriberDEANumber { get; set; }
	public string? specFollowupPrescriberCode { get; set; }
	public int? specFollowupPrescriberVersion { get; set; }
	public string? specFollowupPrescriberLocationCode { get; set; }
	public bool? prohibitRenewalRequest { get; set; }
	public string? erxCode { get; set; }
	public bool? bridgeIndicator { get; set; }
	public string? assetKey { get; set; }
	public string? cancelErxCode { get; set; }
	public Immunization? immunization { get; set; }
	public ExternalReferencesData? externalReferencesData { get; set; }
}

public class EmergencySupply
{
	public string? status { get; set; }
	public string? reauthCode { get; set; }
	public string? rejectionReason { get; set; }
	public string? statusUpdatedBy { get; set; }
	public long? statusUpdateDatetime { get; set; }
}

public class Prescriber
{
	public string? npiNumber { get; set; }
	public string? prescriberCode { get; set; }
	public string? prescriberExternalCode { get; set; }
	public int? prescriberVersion { get; set; }
	public string? lexisNexisPrescriberId { get; set; }
	public string? prescriberLocationExternalCode { get; set; }
	public string? lexisNexisLocationId { get; set; }
	public string? lexisNexisGeoLocationId { get; set; }
	public string? firstName { get; set; }
	public string? middleName { get; set; }
	public string? lastName { get; set; }
	public string? suffix { get; set; }
	public string? addressLine1 { get; set; }
	public string? addressLine2 { get; set; }
	public string? city { get; set; }
	public string? stateCode { get; set; }
	public string? postalCode { get; set; }
	public string? countryCode { get; set; }
	public string? firmName { get; set; }
	public PhoneContact? phoneContact { get; set; }
	public PhoneContactOverride? phoneContactOverride { get; set; }
}

public class PhoneContact
{
	public PhoneNumber? phoneNumber { get; set; }
	public string? type { get; set; }
}

public class PhoneNumber
{
	public string? countryCode { get; set; }
	public string? areaCode { get; set; }
	public string? subscriberNumber { get; set; }
}

public class PhoneContactOverride
{
	public PhoneContact? phoneContact { get; set; }
	public string? updatedBy { get; set; }
	public string? updatedLocation { get; set; }
	public long? updateDateTime { get; set; }
}

public class TransferredFromCompetitor
{
	public CompetitorLocation? competitorLocation { get; set; }
	public EncryptedStringField? competitorRxNumber { get; set; }
	public string? competitorPharmacistName { get; set; }
	public bool? transferredFromWalgreens { get; set; }
	public float? originalRefills { get; set; }
	public long? lastFillDate { get; set; }
	public long? firstFillDate { get; set; }
}

public class CompetitorLocation
{
	public string? locationIdentifier { get; set; }
	public string? locationName { get; set; }
	public string? locationPhoneNumber { get; set; }
	public string? locationFaxNumber { get; set; }
	public string? locationDEANumber { get; set; }
	public string? locationNPINumber { get; set; }
}

public class TransferredToCompetitor
{
	public CompetitorLocation? competitorLocation { get; set; }
	public EncryptedStringField? competitorRxNumber { get; set; }
	public string? competitorPharmacistName { get; set; }
	public string? sendingStoreRph { get; set; }
	public string? transferredBy { get; set; }
	public string? methodOfTransfer { get; set; }
	public bool? transferredToWalgreens { get; set; }
	public float? quantityTransferred { get; set; }
}

public class Immunization
{
	public string? immunizationRxSource { get; set; }
	public bool? offsiteVaccinationClinic { get; set; }
	public int? immunizationRequiredDoses { get; set; }
}

public class ExternalReferencesData
{
	public EncryptedStringField? externalRxNumber { get; set; }
	public string? externalLocationCode { get; set; }
	public bool? everDispensed { get; set; }
	public string? originalAssetKey { get; set; }
	public string? originallyEnteredBy { get; set; }
	public long? originallyEnteredDatetime { get; set; }
	public string? originallyEnteredLocationCode { get; set; }
	public string? intakenBy { get; set; }
	public long? intakenDatetime { get; set; }
	public string? intakenLocationCode { get; set; }
}

public class Patient
{
	public string? patientCode { get; set; }
	public int? patientVersion { get; set; }
	public string? patientExternalCode { get; set; }
	public string? patientLegacyCode { get; set; }
	public PatientDemographic? demographic { get; set; }
	public PatientPreferences? preferences { get; set; }
	public PatientPlans? plans { get; set; }
	public PatientClinicalInfo? clinicalInfo { get; set; }
	public LockedLocation[]? lockedLocations { get; set; }
}

public class PatientDemographic
{
	public Name? name { get; set; }
	public Name? alternateName { get; set; }
	public bool? permanentAddressAvailable { get; set; }
	public Address[]? addresses { get; set; }
	public AttributeCodeValue? race { get; set; }
	public AttributeCodeValue? ethnicity { get; set; }
	public bool? comorbidityStatus { get; set; }
	public long? birthDate { get; set; }
	public string? gender { get; set; }
	public string? sex { get; set; }
	public bool? twin { get; set; }
	public float? weight { get; set; }
	public string? weightUOM { get; set; }
	public float? height { get; set; }
	public string? heightUOM { get; set; }
}

public class Name
{
	public EncryptedStringField? firstName { get; set; }
	public string? middleName { get; set; }
	public EncryptedStringField? lastName { get; set; }
	public string? suffix { get; set; }
	public string? prefix { get; set; }
}

public class Address
{
	public PostalAddressEncrypted? postalAddress { get; set; }
	public string? addressType { get; set; }
	public string? residenceType { get; set; }
}

public class PostalAddressEncrypted
{
	public EncryptedStringField? addressLine1 { get; set; }
	public EncryptedStringField? addressLine2 { get; set; }
	public EncryptedStringField? city { get; set; }
	public string? stateCode { get; set; }
	public string? stateCodeOther { get; set; }
	public EncryptedStringField? postalCode { get; set; }
	public string? countryCode { get; set; }
}

public class AttributeCodeValue
{
	public string? code { get; set; }
	public string? description { get; set; }
}

public class PatientPreferences
{
	public string? language { get; set; }
	public bool? snapCap { get; set; }
	public bool? genericSubstitution { get; set; }
	public bool? autoRefill { get; set; }
	public long? autoRefillUpdateDateTime { get; set; }
	public bool? printLargeLabel { get; set; }
	public bool? convertTo90Day { get; set; }
	public long? convertTo90DayUpdateDateTime { get; set; }
	public bool? verifyBirthDate { get; set; }
	public bool? doubleCount { get; set; }
	public bool? originalContainer { get; set; }
	public bool? multipleInsurancePlans { get; set; }
	public string? noticeOfPrivacyResponse { get; set; }
	public long? noticeOfPrivacyResponseDateTime { get; set; }
	public string? noticeOfPrivacyResponseLocationCode { get; set; }
	public string? expressPayEnrollmentType { get; set; }
	public long? expressPayEnrollmentDateTime { get; set; }
	public bool? saveATripEnrollment { get; set; }
}

public class PatientPlans
{
	public PatientPlan[]? plans { get; set; }
}

public class PatientPlan
{
	public string? type { get; set; }
	public string? planCode { get; set; }
	public EncryptedStringField? generalRecipientNumber { get; set; }
	public long? injuryDate { get; set; }
	public string? pbmMemberId { get; set; }
	public string? patientUPICode { get; set; }
	public string? relationshipType { get; set; }
	public string? thirdPartyPlanType { get; set; }
}

public class PatientClinicalInfo
{
	public PatientClinicalIndicators? clinicalIndicators { get; set; }
	public PatientAllergy[]? allergies { get; set; }
	public PatientHealthCondition[]? healthConditions { get; set; }
}

public class PatientClinicalIndicators
{
	public PatientDeceasedInfo? deceased { get; set; }
	public bool hearingImpaired { get; set; }
	public bool visuallyImpaired { get; set; }
	public bool pet { get; set; }
	public string? petSpecies { get; set; }
	public string? petSpeciesOther { get; set; }
}

public class PatientDeceasedInfo
{
	public long? deceasedDate { get; set; }
}

public class PatientAllergy
{
	public string? allergyQualifier { get; set; }
	public string? code { get; set; }
	public string? description { get; set; }
	public string[]? allergyReactions { get; set; }
	public long? fromDate { get; set; }
	public long? toDate { get; set; }
	public string? updatedBy { get; set; }
	public string? updatedLocation { get; set; }
	public long? updateDateTime { get; set; }
}

public class PatientHealthCondition
{
	public string? healthConditionQualifier { get; set; }
	public string? code { get; set; }
	public string? description { get; set; }
	public long? fromDate { get; set; }
	public long? toDate { get; set; }
	public long? pregnancyDueDate { get; set; }
	public string? updatedBy { get; set; }
	public string? updatedLocation { get; set; }
	public long? updateDateTime { get; set; }
}

public class LockedLocation
{
	public string? locationCode { get; set; }
	public string? createdBy { get; set; }
	public string? createdLocation { get; set; }
	public long? createDateTime { get; set; }
}

public class CPM
{
	public string? eID { get; set; }
	public string? customerID { get; set; }
	public string? consentTypeCode { get; set; }
	public string? consentInd { get; set; }
	public long? consentExpDt { get; set; }
	public string? channelCode { get; set; }
	public string? statusCode { get; set; }
	public EncryptedStringField? rxStatusTextPri { get; set; }
	public EncryptedStringField? rxStatusTextAlt1 { get; set; }
	public EncryptedStringField? rxStatusTextAlt2 { get; set; }
	public EncryptedStringField? rxStatusPhonePri { get; set; }
	public EncryptedStringField? rxStatusPhoneAlt1 { get; set; }
	public EncryptedStringField? rxStatusPhoneAlt2 { get; set; }
	public EncryptedStringField? rxStatusEmail { get; set; }
	public EncryptedStringField? rxStatusApn { get; set; }
	public EncryptedStringField? refillReminderTextPr1 { get; set; }
	public EncryptedStringField? refillReminderTextAlt1 { get; set; }
	public EncryptedStringField? refillReminderTextAlt2 { get; set; }
	public EncryptedStringField? refillReminderPhonePri { get; set; }
	public EncryptedStringField? refillReminderPhoneAlt1 { get; set; }
	public EncryptedStringField? refillReminderPhoneAlt2 { get; set; }
	public EncryptedStringField? refillReminderEmail { get; set; }
	public string? refillReminderApn { get; set; }
	public string? phiTextPri { get; set; }
	public string? phiTextAlt1 { get; set; }
	public string? phiTextAlt2 { get; set; }
	public EncryptedStringField? phiPhone { get; set; }
	public EncryptedStringField? phiEmail { get; set; }
	public string? rxLabelLanguage { get; set; }
	public string? notificationLanguage { get; set; }
	public EncryptedStringField? wellnessResourceTextPri { get; set; }
	public EncryptedStringField? wellnessResourceTextAlt1 { get; set; }
	public EncryptedStringField? wellnessResourceTextAlt2 { get; set; }
	public EncryptedStringField? wellnessResourcePhonePri { get; set; }
	public string? wellnessResourcePhoneAlt1 { get; set; }
	public string? wellnessResourcePhoneAlt2 { get; set; }
	public EncryptedStringField? wellnessResourceEmail { get; set; }
	public string? wellnessResourceApn { get; set; }
	public cpmContact[]? cpmContactsArray { get; set; }
}

public class cpmContact
{
	public string? contactTypeInd { get; set; }
	public string? contactTypeCode { get; set; }
	public EncryptedStringField? emailAddress { get; set; }
	public EncryptedStringField? areaCode { get; set; }
	public EncryptedStringField? phoneFaxNbr { get; set; }
	public long? effectiveDate { get; set; }
	public long? expirationDate { get; set; }
	public string? primaryInd { get; set; }
	public string? textMessagingInd { get; set; }
	public string? restrictedUseCode { get; set; }
	public string? phoneIdentifier { get; set; }
	public string? optInStatus { get; set; }
	public string? qualityCode { get; set; }
}

public class PrescriptionDispenseHistory
{
	public Dispense? dispense { get; set; }
	public PrescriptionHeader? prescriptionHeader { get; set; }
}

public class DecisionDetail
{
	public string? CEPCampaignRuleSetName { get; set; }
	public long? CEPExecutionDateTime { get; set; }
	public long? proposedContactDateTime { get; set; }
	public bool? generalEligibility { get; set; }
	public bool? finalResult { get; set; }
	public Rule[]? rules { get; set; }
}

public class Rule
{
	public string? ruleSequence { get; set; }
	public bool? ruleResult { get; set; }
	public string? ruleName { get; set; }
	public string? ruleValue { get; set; }
}

