﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Wallet2.  ISO2002 ID# _i-iXYZlYEeu76rs9yGlfEg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
public partial record Wallet2
     : IIsoXmlSerilizable<Wallet2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the wallet.
    /// </summary>
    public PartyIdentification258? Provider { get; init; } 
    /// <summary>
    /// Number of days that the user’s PAN has been on file for the user.
    /// </summary>
    public IsoMax5PositiveNumber? PANAge { get; init; } 
    /// <summary>
    /// Number of days since the user wallet account for this user exists.
    /// </summary>
    public IsoMax5PositiveNumber? UserAccountAge { get; init; } 
    /// <summary>
    /// Number of days since the user created the wallet account or started using the wallet.
    /// </summary>
    public IsoMax5PositiveNumber? WalletAccountAge { get; init; } 
    /// <summary>
    /// Number of days since the last activity on the wallet.
    /// </summary>
    public IsoMax5PositiveNumber? DaysSinceLastActivity { get; init; } 
    /// <summary>
    /// Number of transactions on this wallet within an interval.
    /// </summary>
    public IsoMax10PositiveNumber? Activity { get; init; } 
    /// <summary>
    /// Identifies the interval of the activity.
    /// </summary>
    public Frequency12Code? ActivityInterval { get; init; } 
    /// <summary>
    /// Number of days since wallet settings were changed.
    /// </summary>
    public IsoMax5PositiveNumber? LastWalletChange { get; init; } 
    /// <summary>
    /// Number of cards suspended in the wallet.
    /// </summary>
    public IsoMax5PositiveNumber? SuspendedCards { get; init; } 
    /// <summary>
    /// Country of the wallet account.
    /// </summary>
    public ISOMax3ACountryCode? WalletAccountCountry { get; init; } 
    /// <summary>
    /// Method used to capture the card details for the wallet.
    /// </summary>
    public CardDataReading9Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Other method used to capture the card details.
    /// </summary>
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 
    /// <summary>
    /// Number of days the email address has been in the wallet.
    /// </summary>
    public IsoMax5PositiveNumber? WalletAccountEmailAge { get; init; } 
    /// <summary>
    /// Wallet Provider Risk Assessment.
    /// </summary>
    public RiskAssessment1Code? WalletProviderRiskAssessment { get; init; } 
    /// <summary>
    /// Wallet Provider Risk Assessment Model Version used to create scores.
    /// </summary>
    public IsoMax35Text? WalletProviderRiskAssessmentModelVersion { get; init; } 
    /// <summary>
    /// A value to determine trust level of the phone number.
    /// </summary>
    public IsoMax5PositiveNumber? WalletProviderPhoneScore { get; init; } 
    /// <summary>
    /// A value to determine trust level of the device.
    /// </summary>
    public IsoMax5PositiveNumber? WalletProviderDeviceScore { get; init; } 
    /// <summary>
    /// A value to determine trust level of the account.
    /// </summary>
    public IsoMax5PositiveNumber? WalletProviderAccountScore { get; init; } 
    /// <summary>
    /// Additional data associated with wallet.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Provider is PartyIdentification258 ProviderValue)
        {
            writer.WriteStartElement(null, "Prvdr", xmlNamespace );
            ProviderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PANAge is IsoMax5PositiveNumber PANAgeValue)
        {
            writer.WriteStartElement(null, "PANAge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(PANAgeValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (UserAccountAge is IsoMax5PositiveNumber UserAccountAgeValue)
        {
            writer.WriteStartElement(null, "UsrAcctAge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(UserAccountAgeValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (WalletAccountAge is IsoMax5PositiveNumber WalletAccountAgeValue)
        {
            writer.WriteStartElement(null, "WlltAcctAge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(WalletAccountAgeValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (DaysSinceLastActivity is IsoMax5PositiveNumber DaysSinceLastActivityValue)
        {
            writer.WriteStartElement(null, "DaysSncLastActvty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(DaysSinceLastActivityValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (Activity is IsoMax10PositiveNumber ActivityValue)
        {
            writer.WriteStartElement(null, "Actvty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10PositiveNumber(ActivityValue)); // data type Max10PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (ActivityInterval is Frequency12Code ActivityIntervalValue)
        {
            writer.WriteStartElement(null, "ActvtyIntrvl", xmlNamespace );
            writer.WriteValue(ActivityIntervalValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LastWalletChange is IsoMax5PositiveNumber LastWalletChangeValue)
        {
            writer.WriteStartElement(null, "LastWlltChng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(LastWalletChangeValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (SuspendedCards is IsoMax5PositiveNumber SuspendedCardsValue)
        {
            writer.WriteStartElement(null, "SspdCrds", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(SuspendedCardsValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (WalletAccountCountry is ISOMax3ACountryCode WalletAccountCountryValue)
        {
            writer.WriteStartElement(null, "WlltAcctCtry", xmlNamespace );
            writer.WriteValue(WalletAccountCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CardDataEntryMode is CardDataReading9Code CardDataEntryModeValue)
        {
            writer.WriteStartElement(null, "CardDataNtryMd", xmlNamespace );
            writer.WriteValue(CardDataEntryModeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherCardDataEntryMode is IsoMax35Text OtherCardDataEntryModeValue)
        {
            writer.WriteStartElement(null, "OthrCardDataNtryMd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherCardDataEntryModeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (WalletAccountEmailAge is IsoMax5PositiveNumber WalletAccountEmailAgeValue)
        {
            writer.WriteStartElement(null, "WlltAcctEmailAge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(WalletAccountEmailAgeValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (WalletProviderRiskAssessment is RiskAssessment1Code WalletProviderRiskAssessmentValue)
        {
            writer.WriteStartElement(null, "WlltPrvdrRskAssmnt", xmlNamespace );
            writer.WriteValue(WalletProviderRiskAssessmentValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (WalletProviderRiskAssessmentModelVersion is IsoMax35Text WalletProviderRiskAssessmentModelVersionValue)
        {
            writer.WriteStartElement(null, "WlltPrvdrRskAssmntMdlVrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(WalletProviderRiskAssessmentModelVersionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (WalletProviderPhoneScore is IsoMax5PositiveNumber WalletProviderPhoneScoreValue)
        {
            writer.WriteStartElement(null, "WlltPrvdrPhneScore", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(WalletProviderPhoneScoreValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (WalletProviderDeviceScore is IsoMax5PositiveNumber WalletProviderDeviceScoreValue)
        {
            writer.WriteStartElement(null, "WlltPrvdrDvcScore", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(WalletProviderDeviceScoreValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (WalletProviderAccountScore is IsoMax5PositiveNumber WalletProviderAccountScoreValue)
        {
            writer.WriteStartElement(null, "WlltPrvdrAcctScore", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5PositiveNumber(WalletProviderAccountScoreValue)); // data type Max5PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Wallet2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
