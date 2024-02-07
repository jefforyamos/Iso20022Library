﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInformation15.  ISO2002 ID# _PyxaV9p-Ed-ak6NoX_4Aeg_-1837581386.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terms and conditions related to a single invoice to be financed.
/// </summary>
public partial record PaymentInformation15
     : IIsoXmlSerilizable<PaymentInformation15>
{
    #nullable enable
    
    /// <summary>
    /// Payment method that will be used for invoice payment to transfer the funds to the creditor.
    /// </summary>
    public required PaymentMethod4Code PaymentMethod { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account used for payment settlement.
    /// </summary>
    public CashAccount7? PaymentAccount { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtMtd", xmlNamespace );
        writer.WriteValue(PaymentMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (PaymentAccount is CashAccount7 PaymentAccountValue)
        {
            writer.WriteStartElement(null, "PmtAcct", xmlNamespace );
            PaymentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentInformation15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
