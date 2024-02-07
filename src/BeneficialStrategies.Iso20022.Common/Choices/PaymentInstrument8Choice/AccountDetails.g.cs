﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountDetails.  ISO2002 ID# _VKshRtp-Ed-ak6NoX_4Aeg_1485868880.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument8Choice;

/// <summary>
/// Part of the investment account to or from which cash entries are made.
/// </summary>
public partial record AccountDetails : PaymentInstrument8Choice_
     , IIsoXmlSerilizable<AccountDetails>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? AccountIdentification { get; init; } 
    /// <summary>
    /// Account type.
    /// </summary>
    public CashAccountType1? Type { get; init; } 
    
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
        if (Type is CashAccountType1 TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new AccountDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
