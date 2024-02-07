﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction25.  ISO2002 ID# _PyBzcdp-Ed-ak6NoX_4Aeg_-372042206.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
public partial record PaymentTransaction25
     : IIsoXmlSerilizable<PaymentTransaction25>
{
    #nullable enable
    
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    public CashInOrOut5Choice_? CashInOrOut { get; init; } 
    
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
        if (CashInOrOut is CashInOrOut5Choice_ CashInOrOutValue)
        {
            writer.WriteStartElement(null, "CshInOrOut", xmlNamespace );
            CashInOrOutValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction25 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
