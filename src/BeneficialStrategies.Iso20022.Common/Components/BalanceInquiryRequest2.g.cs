﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceInquiryRequest2.  ISO2002 ID# _YW_NMYYLEemxIqbaFEE8-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Request message.
/// </summary>
public partial record BalanceInquiryRequest2
     : IIsoXmlSerilizable<BalanceInquiryRequest2>
{
    #nullable enable
    
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    public LoyaltyAccountRequest1? LoyaltyAccountRequest { get; init; } 
    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    public StoredValueRequest2? StoredValueAccountRequest { get; init; } 
    
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
        if (PaymentAccountRequest is PaymentAccountRequest1 PaymentAccountRequestValue)
        {
            writer.WriteStartElement(null, "PmtAcctReq", xmlNamespace );
            PaymentAccountRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LoyaltyAccountRequest is LoyaltyAccountRequest1 LoyaltyAccountRequestValue)
        {
            writer.WriteStartElement(null, "LltyAcctReq", xmlNamespace );
            LoyaltyAccountRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StoredValueAccountRequest is StoredValueRequest2 StoredValueAccountRequestValue)
        {
            writer.WriteStartElement(null, "StordValAcctReq", xmlNamespace );
            StoredValueAccountRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BalanceInquiryRequest2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
