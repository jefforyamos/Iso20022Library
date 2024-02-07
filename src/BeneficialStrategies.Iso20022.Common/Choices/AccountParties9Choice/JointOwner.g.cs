﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for JointOwner.  ISO2002 ID# _PfIHmyCBEeWhHbfCMWc1cw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties9Choice;

/// <summary>
/// Co-owner of the investment account when the ownership is assigned to more than one party.
/// </summary>
public partial record JointOwner : AccountParties9Choice_
     , IIsoXmlSerilizable<JointOwner>
{
    #nullable enable
    
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required Party30Choice_ Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Information related to the party profile to be inserted or deleted.
    /// </summary>
    public ModificationScope27? ModifiedInvestorProfileValidation { get; init; } 
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
    /// </summary>
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public IsoMax35Text? ClientIdentification { get; init; } 
    /// <summary>
    /// Indicates whether an owner of the account may benefit from a fiscal exemption or amnesty, for example, when declaring overseas investments.
    /// </summary>
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    /// <summary>
    /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
    /// </summary>
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    /// <summary>
    /// Details about the MiFID classification of the account owner.
    /// </summary>
    public MiFIDClassification1? MiFIDClassification { get; init; } 
    /// <summary>
    /// Type of information that must be provided to the account holder.
    /// </summary>
    public Notification2? Notification { get; init; } 
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor or account owner.
    /// </summary>
    public FATCAForm1Choice_? FATCAFormType { get; init; } 
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status of the investor or account owner.
    /// </summary>
    public FATCAStatus2? FATCAStatus { get; init; } 
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public GenericIdentification82? OtherIdentification { get; init; } 
    /// <summary>
    /// Tax advantage specific to the account party.
    /// </summary>
    public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    public TaxReporting1? TaxReporting { get; init; } 
    /// <summary>
    /// Language in which the organisation or person communicates.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Method used for postal mailing.
    /// </summary>
    public MailType1Choice_? MailType { get; init; } 
    /// <summary>
    /// Country and residential status of the organisation or individual person.
    /// </summary>
    public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Annual wealth of the individual person or share capital value of the legal entity and date on which the annual wealth of the individual person was registered or declared or the date the stock value of the organisation was registered.
    /// </summary>
    public DateAndAmount1? MonetaryWealth { get; init; } 
    /// <summary>
    /// Amount of total assets minus liabilities of the individual person or the amount of the difference between assets and liabilities plus rights over obligations (net equity) of the organisation and the date on which the equity value was registered.
    /// </summary>
    public DateAndAmount1? EquityValue { get; init; } 
    /// <summary>
    /// Resource or value owned or used by a third-party company and the date on which the working capital amount was registered.
    /// </summary>
    public DateAndAmount1? WorkingCapital { get; init; } 
    /// <summary>
    /// Account owner's connection with the trading party or broker.
    /// </summary>
    public CompanyLink1Choice_? CompanyLink { get; init; } 
    /// <summary>
    /// Reference to be specified when a letter (for example, an order confirmation) is sent by an automated mailing system.
    /// </summary>
    public IsoMax350Text? ElectronicMailingServiceReference { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? SecondaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Additional regulatory information about the investor or account owner that is required in some markets to support anti-money laundering laws.
    /// </summary>
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    /// <summary>
    /// Specifies if the account party is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    public AccountingStatus1Choice_? AccountingStatus { get; init; } 
    /// <summary>
    /// Additional information concerning limitations and restrictions on the account party.
    /// </summary>
    public AccountRestrictions1? AdditionalInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MoneyLaunderingCheck is MoneyLaunderingCheck1Choice_ MoneyLaunderingCheckValue)
        {
            writer.WriteStartElement(null, "MnyLndrgChck", xmlNamespace );
            MoneyLaunderingCheckValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ModifiedInvestorProfileValidation is ModificationScope27 ModifiedInvestorProfileValidationValue)
        {
            writer.WriteStartElement(null, "ModfdInvstrPrflVldtn", xmlNamespace );
            ModifiedInvestorProfileValidationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OwnershipBeneficiaryRate is IsoPercentageRate OwnershipBeneficiaryRateValue)
        {
            writer.WriteStartElement(null, "OwnrshBnfcryRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(OwnershipBeneficiaryRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (ClientIdentification is IsoMax35Text ClientIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FiscalExemption is IsoYesNoIndicator FiscalExemptionValue)
        {
            writer.WriteStartElement(null, "FsclXmptn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FiscalExemptionValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SignatoryRightIndicator is IsoYesNoIndicator SignatoryRightIndicatorValue)
        {
            writer.WriteStartElement(null, "SgntryRghtInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SignatoryRightIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (MiFIDClassification is MiFIDClassification1 MiFIDClassificationValue)
        {
            writer.WriteStartElement(null, "MiFIDClssfctn", xmlNamespace );
            MiFIDClassificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Notification is Notification2 NotificationValue)
        {
            writer.WriteStartElement(null, "Ntfctn", xmlNamespace );
            NotificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FATCAFormType is FATCAForm1Choice_ FATCAFormTypeValue)
        {
            writer.WriteStartElement(null, "FATCAFormTp", xmlNamespace );
            FATCAFormTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FATCAStatus is FATCAStatus2 FATCAStatusValue)
        {
            writer.WriteStartElement(null, "FATCASts", xmlNamespace );
            FATCAStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherIdentification is GenericIdentification82 OtherIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrId", xmlNamespace );
            OtherIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxExemption is TaxExemptionReason2Choice_ TaxExemptionValue)
        {
            writer.WriteStartElement(null, "TaxXmptn", xmlNamespace );
            TaxExemptionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxReporting is TaxReporting1 TaxReportingValue)
        {
            writer.WriteStartElement(null, "TaxRptg", xmlNamespace );
            TaxReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Language is LanguageCode LanguageValue)
        {
            writer.WriteStartElement(null, "Lang", xmlNamespace );
            writer.WriteValue(LanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MailType is MailType1Choice_ MailTypeValue)
        {
            writer.WriteStartElement(null, "MailTp", xmlNamespace );
            MailTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CountryAndResidentialStatus is CountryAndResidentialStatusType2 CountryAndResidentialStatusValue)
        {
            writer.WriteStartElement(null, "CtryAndResdtlSts", xmlNamespace );
            CountryAndResidentialStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MonetaryWealth is DateAndAmount1 MonetaryWealthValue)
        {
            writer.WriteStartElement(null, "MntryWlth", xmlNamespace );
            MonetaryWealthValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EquityValue is DateAndAmount1 EquityValueValue)
        {
            writer.WriteStartElement(null, "EqtyVal", xmlNamespace );
            EquityValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WorkingCapital is DateAndAmount1 WorkingCapitalValue)
        {
            writer.WriteStartElement(null, "WorkgCptl", xmlNamespace );
            WorkingCapitalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CompanyLink is CompanyLink1Choice_ CompanyLinkValue)
        {
            writer.WriteStartElement(null, "CpnyLk", xmlNamespace );
            CompanyLinkValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ElectronicMailingServiceReference is IsoMax350Text ElectronicMailingServiceReferenceValue)
        {
            writer.WriteStartElement(null, "ElctrncMlngSvcRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(ElectronicMailingServiceReferenceValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (PrimaryCommunicationAddress is CommunicationAddress6 PrimaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "PmryComAdr", xmlNamespace );
            PrimaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryCommunicationAddress is CommunicationAddress6 SecondaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "ScndryComAdr", xmlNamespace );
            SecondaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalRegulatoryInformation is RegulatoryInformation1 AdditionalRegulatoryInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRgltryInf", xmlNamespace );
            AdditionalRegulatoryInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountingStatus is AccountingStatus1Choice_ AccountingStatusValue)
        {
            writer.WriteStartElement(null, "AcctgSts", xmlNamespace );
            AccountingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AccountRestrictions1 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new JointOwner Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
