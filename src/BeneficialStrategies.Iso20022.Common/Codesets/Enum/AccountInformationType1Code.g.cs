﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountInformationType1Code.  ISO2002 ID# _I_zgUH6GEeSAlrUr1Vow5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I_zgUH6GEeSAlrUr1Vow5g")]
[Description(@"Specifies the type of account information.")]
[DerivedFrom(typeof(AccountInformationTypeCode))]
public enum AccountInformationType1Code
{
    /// <summary>
    /// Name of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBND".
    /// </summary>
    [EnumMember(Value = "IBND")]
    [IsoId("_5uluIX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of intermediary bank for dealt currency.")]
    IntermediaryBankNameOfDealtCurrency = AccountInformationTypeCode.IntermediaryBankNameOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBCC".
    /// </summary>
    [EnumMember(Value = "IBCC")]
    [IsoId("_50Dc8X6HEeSAlrUr1Vow5g")]
    [Description(@"Number of intermediary bank for contra currency.")]
    IntermediaryBankNumberOfContraCurrency = AccountInformationTypeCode.IntermediaryBankNumberOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBDC".
    /// </summary>
    [EnumMember(Value = "IBDC")]
    [IsoId("_55bsMX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of intermediary bank for dealt currency.")]
    IntermediaryBankNumberOfDealtCurrency = AccountInformationTypeCode.IntermediaryBankNumberOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BIBC".
    /// </summary>
    [EnumMember(Value = "BIBC")]
    [IsoId("_6MzUIX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionBICCodeOfContraCurrency = AccountInformationTypeCode.BeneficiaryInstitutionBICCodeOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIBD".
    /// </summary>
    [EnumMember(Value = "BIBD")]
    [IsoId("_6SMxgX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionBICCodeOfDealtCurrency = AccountInformationTypeCode.BeneficiaryInstitutionBICCodeOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BINC".
    /// </summary>
    [EnumMember(Value = "BINC")]
    [IsoId("_6XsVgX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNameOfContraCurrency = AccountInformationTypeCode.BeneficiaryInstitutionNameOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIND".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_6dCvkX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNameOfDealtCurrency = AccountInformationTypeCode.BeneficiaryInstitutionNameOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BICC".
    /// </summary>
    [EnumMember(Value = "BICC")]
    [IsoId("_6ocHQX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNumberOfContraCurrency = AccountInformationTypeCode.BeneficiaryInstitutionNumberOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIDC".
    /// </summary>
    [EnumMember(Value = "BIDC")]
    [IsoId("_6tx6QX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNumberOfDealtCurrency = AccountInformationTypeCode.BeneficiaryInstitutionNumberOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Margin settlement account number of CFETS.
    /// Encoded/decoded by serializers as "CMSA".
    /// </summary>
    [EnumMember(Value = "CMSA")]
    [IsoId("_6zI7YX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of CFETS.")]
    CFETSMarginSettlementAccountNumber = AccountInformationTypeCode.CFETSMarginSettlementAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBBC".
    /// </summary>
    [EnumMember(Value = "CBBC")]
    [IsoId("_606dAX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of correspondent bank for contra currency.")]
    CorrespondentBankBICCodeOfContraCurrency = AccountInformationTypeCode.CorrespondentBankBICCodeOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBBD".
    /// </summary>
    [EnumMember(Value = "CBBD")]
    [IsoId("_66MloX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of correspondent bank for dealt currency.")]
    CorrespondentBankBICCodeOfDealtCurrency = AccountInformationTypeCode.CorrespondentBankBICCodeOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBNC".
    /// </summary>
    [EnumMember(Value = "CBNC")]
    [IsoId("_6_eHMX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of correspondent bank for contra currency.")]
    CorrespondentBankNameOfContraCurrency = AccountInformationTypeCode.CorrespondentBankNameOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBND".
    /// </summary>
    [EnumMember(Value = "CBND")]
    [IsoId("_7BSsIX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of correspondent bank for dealt currency.")]
    CorrespondentBankNameOfDealtCurrency = AccountInformationTypeCode.CorrespondentBankNameOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBCC".
    /// </summary>
    [EnumMember(Value = "CBCC")]
    [IsoId("_7GofIX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of correspondent bank for contra currency.")]
    CorrespondentBankNumberOfContraCurrency = AccountInformationTypeCode.CorrespondentBankNumberOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBDC".
    /// </summary>
    [EnumMember(Value = "CBDC")]
    [IsoId("_7L6nwX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of correspondent bank for dealt currency.")]
    CorrespondentBankNumberOfDealtCurrency = AccountInformationTypeCode.CorrespondentBankNumberOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the current account.
    /// Encoded/decoded by serializers as "CUAC".
    /// </summary>
    [EnumMember(Value = "CUAC")]
    [IsoId("_7Nq7QX6HEeSAlrUr1Vow5g")]
    [Description(@"Specifies the current account.")]
    CurrentAccount = AccountInformationTypeCode.CurrentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the deposit account.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_7S-SAX6HEeSAlrUr1Vow5g")]
    [Description(@"Specifies the deposit account.")]
    DepositAccount = AccountInformationTypeCode.DepositAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account name of fund custodian.
    /// Encoded/decoded by serializers as "FCAA".
    /// </summary>
    [EnumMember(Value = "FCAA")]
    [IsoId("_7YRBsX6HEeSAlrUr1Vow5g")]
    [Description(@"Account name of fund custodian.")]
    FundCustodianAccountName = AccountInformationTypeCode.FundCustodianAccountName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number of fund custodian.
    /// Encoded/decoded by serializers as "FCAN".
    /// </summary>
    [EnumMember(Value = "FCAN")]
    [IsoId("_7hJQ4X6HEeSAlrUr1Vow5g")]
    [Description(@"Account number of fund custodian.")]
    FundCustodianAccountNumber = AccountInformationTypeCode.FundCustodianAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of fund custodian bank.
    /// Encoded/decoded by serializers as "FCBN".
    /// </summary>
    [EnumMember(Value = "FCBN")]
    [IsoId("_7mbZgX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of fund custodian bank.")]
    FundCustodianBankName = AccountInformationTypeCode.FundCustodianBankName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBBC".
    /// </summary>
    [EnumMember(Value = "IBBC")]
    [IsoId("_7rv-YX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of intermediary bank for contra currency.")]
    IntermediaryBankBICCodeOfContraCurrency = AccountInformationTypeCode.IntermediaryBankBICCodeOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC code of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBBD".
    /// </summary>
    [EnumMember(Value = "IBBD")]
    [IsoId("_7xCuEX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of intermediary bank for dealt currency.")]
    IntermediaryBankBICCodeOfDealtCurrency = AccountInformationTypeCode.IntermediaryBankBICCodeOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBNC".
    /// </summary>
    [EnumMember(Value = "IBNC")]
    [IsoId("_72UPoX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of intermediary bank for contra currency.")]
    IntermediaryBankNameOfContraCurrency = AccountInformationTypeCode.IntermediaryBankNameOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian account name of margin.
    /// Encoded/decoded by serializers as "MCAA".
    /// </summary>
    [EnumMember(Value = "MCAA")]
    [IsoId("_8qp2oX6HEeSAlrUr1Vow5g")]
    [Description(@"Custodian account name of margin.")]
    MarginCustodianAccountName = AccountInformationTypeCode.MarginCustodianAccountName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian account number of margin.
    /// Encoded/decoded by serializers as "MCAN".
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_8wHlcX6HEeSAlrUr1Vow5g")]
    [Description(@"Custodian account number of margin.")]
    MarginCustodianAccountNumber = AccountInformationTypeCode.MarginCustodianAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code of margin custodian institution.
    /// Encoded/decoded by serializers as "MCIC".
    /// </summary>
    [EnumMember(Value = "MCIC")]
    [IsoId("_81o-oX6HEeSAlrUr1Vow5g")]
    [Description(@"Code of margin custodian institution.")]
    MarginCustodianInstitutionCode = AccountInformationTypeCode.MarginCustodianInstitutionCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of margin custodian institution.
    /// Encoded/decoded by serializers as "MCIN".
    /// </summary>
    [EnumMember(Value = "MCIN")]
    [IsoId("_86__wX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of margin custodian institution.")]
    MarginCustodianInstitutionName = AccountInformationTypeCode.MarginCustodianInstitutionName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement account name of margin.
    /// Encoded/decoded by serializers as "MSAA".
    /// </summary>
    [EnumMember(Value = "MSAA")]
    [IsoId("_9AY2EX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement account name of margin.")]
    MarginSettlementAccountName = AccountInformationTypeCode.MarginSettlementAccountName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement bank name of margin.
    /// Encoded/decoded by serializers as "MSBN".
    /// </summary>
    [EnumMember(Value = "MSBN")]
    [IsoId("_9COCEX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement bank name of margin.")]
    MarginSettlementBankName = AccountInformationTypeCode.MarginSettlementBankName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Description of multi currency account.
    /// Encoded/decoded by serializers as "MCAD".
    /// </summary>
    [EnumMember(Value = "MCAD")]
    [IsoId("_9Hm4YX6HEeSAlrUr1Vow5g")]
    [Description(@"Description of multi currency account.")]
    MultiCurrencyAccountDescription = AccountInformationTypeCode.MultiCurrencyAccountDescription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Note for dealt currency.
    /// Encoded/decoded by serializers as "NODC".
    /// </summary>
    [EnumMember(Value = "NODC")]
    [IsoId("_9JXy8X6HEeSAlrUr1Vow5g")]
    [Description(@"Note for dealt currency.")]
    NoteOfDealtCurrency = AccountInformationTypeCode.NoteOfDealtCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account chinese name of securities custodians.
    /// Encoded/decoded by serializers as "SCAC".
    /// </summary>
    [EnumMember(Value = "SCAC")]
    [IsoId("_9OrJsX6HEeSAlrUr1Vow5g")]
    [Description(@"Account chinese name of securities custodians.")]
    SecuritiesCustodianAccountChineseName = AccountInformationTypeCode.SecuritiesCustodianAccountChineseName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account name of securities custodians.
    /// Encoded/decoded by serializers as "SCAA".
    /// </summary>
    [EnumMember(Value = "SCAA")]
    [IsoId("_9Qa2IX6HEeSAlrUr1Vow5g")]
    [Description(@"Account name of securities custodians.")]
    SecuritiesCustodianAccountName = AccountInformationTypeCode.SecuritiesCustodianAccountName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Margin settlement account number of other institutions.
    /// Encoded/decoded by serializers as "OMSA".
    /// </summary>
    [EnumMember(Value = "OMSA")]
    [IsoId("_9ZggsX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of other institutions.")]
    OtherMarginSettlementAccountNumber = AccountInformationTypeCode.OtherMarginSettlementAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Note for contra currency.
    /// Encoded/decoded by serializers as "NOCC".
    /// </summary>
    [EnumMember(Value = "NOCC")]
    [IsoId("_9e1soX6HEeSAlrUr1Vow5g")]
    [Description(@"Note for contra currency.")]
    NoteOfContraCurrency = AccountInformationTypeCode.NoteOfContraCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement bank sort code of margin.
    /// Encoded/decoded by serializers as "MSBS".
    /// </summary>
    [EnumMember(Value = "MSBS")]
    [IsoId("_9kJDYX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement bank sort code of margin.")]
    MarginSettlementBankSortCode = AccountInformationTypeCode.MarginSettlementBankSortCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Margin settlement account number of CDC.
    /// Encoded/decoded by serializers as "MSAN".
    /// </summary>
    [EnumMember(Value = "MSAN")]
    [IsoId("_9pbzEX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of CDC.")]
    MarginSettlementAccountNumber = AccountInformationTypeCode.MarginSettlementAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number of securities custodians.
    /// Encoded/decoded by serializers as "SCAN".
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_-K-Z4X6HEeSAlrUr1Vow5g")]
    [Description(@"Account number of securities custodians.")]
    SecuritiesCustodianAccountNumber = AccountInformationTypeCode.SecuritiesCustodianAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code of securities custodian institution.
    /// Encoded/decoded by serializers as "SCIC".
    /// </summary>
    [EnumMember(Value = "SCIC")]
    [IsoId("_-QS-wX6HEeSAlrUr1Vow5g")]
    [Description(@"Code of securities custodian institution.")]
    SecuritiesCustodianInstitutionCode = AccountInformationTypeCode.SecuritiesCustodianInstitutionCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of securities custodian institution.
    /// Encoded/decoded by serializers as "SCIN".
    /// </summary>
    [EnumMember(Value = "SCIN")]
    [IsoId("_-VoKsX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of securities custodian institution.")]
    SecuritiesCustodianInstitutionName = AccountInformationTypeCode.SecuritiesCustodianInstitutionName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of cash account.
    /// Encoded/decoded by serializers as "SOCA".
    /// </summary>
    [EnumMember(Value = "SOCA")]
    [IsoId("_-a66YX6HEeSAlrUr1Vow5g")]
    [Description(@"Status of cash account.")]
    StatusOfCashAccount = AccountInformationTypeCode.StatusOfCashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of securities custodian account.
    /// Encoded/decoded by serializers as "SSCA".
    /// </summary>
    [EnumMember(Value = "SSCA")]
    [IsoId("_-gORIX6HEeSAlrUr1Vow5g")]
    [Description(@"Status of securities custodian account.")]
    StatusOfSecuritiesCustodianAccount = AccountInformationTypeCode.StatusOfSecuritiesCustodianAccount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountInformationType1CodeMetadataExtensions
{
    private static readonly AccountInformationType1CodeDropdownSource _dropdownSource = new AccountInformationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountInformationType1CodeDropdownRow GetMetadata(this AccountInformationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


