﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CashAccountDetails.  ISO2002 ID# _SBhw59p-Ed-ak6NoX_4Aeg_-925008187.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument11Choice;

/// <summary>
/// Part of the investment account to or from which cash entries are made.
/// </summary>
public partial record CashAccountDetails : PaymentInstrument11Choice_
     , IIsoXmlSerilizable<CashAccountDetails>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? AccountIdentification { get; init; } 
    /// <summary>
    /// Account type.
    /// </summary>
    public FundCashAccount2Code? Type { get; init; } 
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    public IsoExtended350Code? ExtendedType { get; init; } 
    
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
        if (AccountIdentification is AccountIdentification1 AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Type is FundCashAccount2Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExtendedType is IsoExtended350Code ExtendedTypeValue)
        {
            writer.WriteStartElement(null, "XtndedTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedTypeValue)); // data type Extended350Code System.String
            writer.WriteEndElement();
        }
    }
    public static new CashAccountDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
