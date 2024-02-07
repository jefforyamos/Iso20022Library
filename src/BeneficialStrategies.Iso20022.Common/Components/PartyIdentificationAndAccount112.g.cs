﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount112.  ISO2002 ID# _E3Yeqx5gEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount112
     : IIsoXmlSerilizable<PartyIdentificationAndAccount112>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification94Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification7 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccount is CashAccountIdentification5Choice_ CashAccountValue)
        {
            writer.WriteStartElement(null, "CshAcct", xmlNamespace );
            CashAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesAccount is CashAccountIdentification5Choice_ ChargesAccountValue)
        {
            writer.WriteStartElement(null, "ChrgsAcct", xmlNamespace );
            ChargesAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommissionAccount is CashAccountIdentification5Choice_ CommissionAccountValue)
        {
            writer.WriteStartElement(null, "ComssnAcct", xmlNamespace );
            CommissionAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxAccount is CashAccountIdentification5Choice_ TaxAccountValue)
        {
            writer.WriteStartElement(null, "TaxAcct", xmlNamespace );
            TaxAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is PartyTextInformation2 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationAndAccount112 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
