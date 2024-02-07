﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingServicesAmount2.  ISO2002 ID# _6QP-p5qlEeGSON8vddiWzQ_460369359.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxable service charge amount conversions to host currency.
/// </summary>
public partial record BillingServicesAmount2
     : IIsoXmlSerilizable<BillingServicesAmount2>
{
    #nullable enable
    
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values. It represents the total charge for a service (including taxes) expressed in the host currency.
    /// </summary>
    public required AmountAndDirection34 HostAmount { get; init; } 
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the settlement currency.
    /// </summary>
    public AmountAndDirection34? SettlementAmount { get; init; } 
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the pricing currency.
    /// </summary>
    public AmountAndDirection34? PricingAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "HstAmt", xmlNamespace );
        HostAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementAmount is AmountAndDirection34 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PricingAmount is AmountAndDirection34 PricingAmountValue)
        {
            writer.WriteStartElement(null, "PricgAmt", xmlNamespace );
            PricingAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BillingServicesAmount2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
