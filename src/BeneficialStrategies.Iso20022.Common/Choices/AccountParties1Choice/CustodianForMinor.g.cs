﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CustodianForMinor.  ISO2002 ID# _5n7tmxdAEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties1Choice;

/// <summary>
/// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
/// </summary>
public partial record CustodianForMinor : AccountParties1Choice_
     , IIsoXmlSerilizable<CustodianForMinor>
{
    #nullable enable
    
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required Party14Choice_ Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    public PartyProfileInformation2? InvestorProfileValidation { get; init; } 
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public IsoMax35Text? ClientIdentification { get; init; } 
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
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
    /// Specifies how information is sent to the account holder.
    /// </summary>
    public InformationDistribution1Code? InformationDistribution { get; init; } 
    
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
        if (InvestorProfileValidation is PartyProfileInformation2 InvestorProfileValidationValue)
        {
            writer.WriteStartElement(null, "InvstrPrflVldtn", xmlNamespace );
            InvestorProfileValidationValue.Serialize(writer, xmlNamespace);
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
        if (InformationDistribution is InformationDistribution1Code InformationDistributionValue)
        {
            writer.WriteStartElement(null, "InfDstrbtn", xmlNamespace );
            writer.WriteValue(InformationDistributionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new CustodianForMinor Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
