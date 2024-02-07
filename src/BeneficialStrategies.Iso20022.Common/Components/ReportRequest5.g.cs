﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportRequest5.  ISO2002 ID# _9eR5cU6uEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
public partial record ReportRequest5
     : IIsoXmlSerilizable<ReportRequest5>
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
    public required RetailerService6Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Transaction Report Request message.
    /// </summary>
    public ReportTransactionRequest1? ReportTransactionRequest { get; init; } 
    /// <summary>
    /// Content of the Get Totals Request message.
    /// </summary>
    public ReportGetTotalsRequest1? ReportGetTotalsRequest { get; init; } 
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
        if (ReportTransactionRequest is ReportTransactionRequest1 ReportTransactionRequestValue)
        {
            writer.WriteStartElement(null, "RptTxReq", xmlNamespace );
            ReportTransactionRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReportGetTotalsRequest is ReportGetTotalsRequest1 ReportGetTotalsRequestValue)
        {
            writer.WriteStartElement(null, "RptGetTtlsReq", xmlNamespace );
            ReportGetTotalsRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReportRequest5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
