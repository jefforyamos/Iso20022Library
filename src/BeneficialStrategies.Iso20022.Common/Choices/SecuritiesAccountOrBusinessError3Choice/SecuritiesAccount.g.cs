﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesAccount.  ISO2002 ID# _yNtKMTp1Eemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError3Choice;

/// <summary>
/// Specifies the data requested for the securities account.
/// </summary>
public partial record SecuritiesAccount : SecuritiesAccountOrBusinessError3Choice_
     , IIsoXmlSerilizable<SecuritiesAccount>
{
    #nullable enable
    
    /// <summary>
    /// Legal opening date of the securities account.
    /// </summary>
    public IsoISODate? OpeningDate { get; init; } 
    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Indicates whether the securities account is on hold or not.
    /// Usage:
    /// - Meaning when true: account is in hold status.
    /// - Meaning when false: account is in release status.
    /// </summary>
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    public IsoTrueFalseIndicator? NegativePosition { get; init; } 
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    public SystemSecuritiesAccountType1Choice_? Type { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required SystemPartyIdentification8 AccountOwner { get; init; } 
    /// <summary>
    /// Specifies the type of party owning the account.
    /// </summary>
    public SystemPartyType1Choice_? PartyType { get; init; } 
    /// <summary>
    /// Additional attributes defined by a central security depositary for a securities account.
    /// </summary>
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    public SystemRestriction1? Restriction { get; init; } 
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    
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
        if (OpeningDate is IsoISODate OpeningDateValue)
        {
            writer.WriteStartElement(null, "OpngDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OpeningDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ClosingDate is IsoISODate ClosingDateValue)
        {
            writer.WriteStartElement(null, "ClsgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ClosingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (HoldIndicator is IsoTrueFalseIndicator HoldIndicatorValue)
        {
            writer.WriteStartElement(null, "HldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(HoldIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (NegativePosition is IsoTrueFalseIndicator NegativePositionValue)
        {
            writer.WriteStartElement(null, "NegPos", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(NegativePositionValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (Type is SystemSecuritiesAccountType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
        AccountOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PartyType is SystemPartyType1Choice_ PartyTypeValue)
        {
            writer.WriteStartElement(null, "PtyTp", xmlNamespace );
            PartyTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketSpecificAttribute is MarketSpecificAttribute1 MarketSpecificAttributeValue)
        {
            writer.WriteStartElement(null, "MktSpcfcAttr", xmlNamespace );
            MarketSpecificAttributeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Restriction is SystemRestriction1 RestrictionValue)
        {
            writer.WriteStartElement(null, "Rstrctn", xmlNamespace );
            RestrictionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EndInvestorFlag is IsoExact4AlphaNumericText EndInvestorFlagValue)
        {
            writer.WriteStartElement(null, "EndInvstrFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(EndInvestorFlagValue)); // data type Exact4AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (PricingScheme is IsoExact4AlphaNumericText PricingSchemeValue)
        {
            writer.WriteStartElement(null, "PricgSchme", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(PricingSchemeValue)); // data type Exact4AlphaNumericText System.String
            writer.WriteEndElement();
        }
    }
    public static new SecuritiesAccount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
