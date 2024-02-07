﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceRequest5.  ISO2002 ID# _R3lwcU31Eey_VecAUE-C9Q.
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
public partial record ServiceRequest5
     : IIsoXmlSerilizable<ServiceRequest5>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext29 Context { get; init; } 
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    public required RetailerService2Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the payment request.
    /// </summary>
    public PaymentRequest4? PaymentRequest { get; init; } 
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    public ReversalRequest4? ReversalRequest { get; init; } 
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    public BalanceInquiryRequest5? BalanceInquiryRequest { get; init; } 
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    public LoyaltyRequest4? LoyaltyRequest { get; init; } 
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    public StoredValueRequest5? StoredValueRequest { get; init; } 
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    public BatchRequest4? BatchRequest { get; init; } 
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    public EnableServiceRequest4? EnableServiceRequest { get; init; } 
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; } 
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
        if (PaymentRequest is PaymentRequest4 PaymentRequestValue)
        {
            writer.WriteStartElement(null, "PmtReq", xmlNamespace );
            PaymentRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReversalRequest is ReversalRequest4 ReversalRequestValue)
        {
            writer.WriteStartElement(null, "RvslReq", xmlNamespace );
            ReversalRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceInquiryRequest is BalanceInquiryRequest5 BalanceInquiryRequestValue)
        {
            writer.WriteStartElement(null, "BalNqryReq", xmlNamespace );
            BalanceInquiryRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LoyaltyRequest is LoyaltyRequest4 LoyaltyRequestValue)
        {
            writer.WriteStartElement(null, "LltyReq", xmlNamespace );
            LoyaltyRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StoredValueRequest is StoredValueRequest5 StoredValueRequestValue)
        {
            writer.WriteStartElement(null, "StordValReq", xmlNamespace );
            StoredValueRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BatchRequest is BatchRequest4 BatchRequestValue)
        {
            writer.WriteStartElement(null, "BtchReq", xmlNamespace );
            BatchRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EnableServiceRequest is EnableServiceRequest4 EnableServiceRequestValue)
        {
            writer.WriteStartElement(null, "NblSvcReq", xmlNamespace );
            EnableServiceRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardAcquisitionRequest is CardAcquisitionRequest3 CardAcquisitionRequestValue)
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
    public static ServiceRequest5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
