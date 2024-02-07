﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceRequest2.  ISO2002 ID# _ndUwoYX_EemxIqbaFEE8-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component defines the service to be called.
/// </summary>
public partial record ServiceRequest2
     : IIsoXmlSerilizable<ServiceRequest2>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment73 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext27 Context { get; init; } 
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    public required RetailerService2Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the payment request.
    /// </summary>
    public PaymentRequest1? PaymentRequest { get; init; } 
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    public ReversalRequest1? ReversalRequest { get; init; } 
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    public BalanceInquiryRequest2? BalanceInquiryRequest { get; init; } 
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    public LoyaltyRequest1? LoyaltyRequest { get; init; } 
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    public StoredValueRequest2? StoredValueRequest { get; init; } 
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    public BatchRequest1? BatchRequest { get; init; } 
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    public EnableServiceRequest1? EnableServiceRequest { get; init; } 
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cntxt", xmlNamespace );
        Context.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SvcCntt", xmlNamespace );
        writer.WriteValue(ServiceContent.ToString()); // Enum value
        writer.WriteEndElement();
        if (PaymentRequest is PaymentRequest1 PaymentRequestValue)
        {
            writer.WriteStartElement(null, "PmtReq", xmlNamespace );
            PaymentRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReversalRequest is ReversalRequest1 ReversalRequestValue)
        {
            writer.WriteStartElement(null, "RvslReq", xmlNamespace );
            ReversalRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceInquiryRequest is BalanceInquiryRequest2 BalanceInquiryRequestValue)
        {
            writer.WriteStartElement(null, "BalNqryReq", xmlNamespace );
            BalanceInquiryRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LoyaltyRequest is LoyaltyRequest1 LoyaltyRequestValue)
        {
            writer.WriteStartElement(null, "LltyReq", xmlNamespace );
            LoyaltyRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StoredValueRequest is StoredValueRequest2 StoredValueRequestValue)
        {
            writer.WriteStartElement(null, "StordValReq", xmlNamespace );
            StoredValueRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BatchRequest is BatchRequest1 BatchRequestValue)
        {
            writer.WriteStartElement(null, "BtchReq", xmlNamespace );
            BatchRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EnableServiceRequest is EnableServiceRequest1 EnableServiceRequestValue)
        {
            writer.WriteStartElement(null, "NblSvcReq", xmlNamespace );
            EnableServiceRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardAcquisitionRequest is CardAcquisitionRequest2 CardAcquisitionRequestValue)
        {
            writer.WriteStartElement(null, "CardAcqstnReq", xmlNamespace );
            CardAcquisitionRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ServiceRequest2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
