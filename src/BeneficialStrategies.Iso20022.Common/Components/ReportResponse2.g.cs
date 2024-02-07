﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportResponse2.  ISO2002 ID# _WdsfYYYCEemxIqbaFEE8-w.
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
public partial record ReportResponse2
     : IIsoXmlSerilizable<ReportResponse2>
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
    public required RetailerService7Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    public ReportTransactionResponse1? ReportTransactionResponse { get; init; } 
    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType9 Response { get; init; } 
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
        if (ReportTransactionResponse is ReportTransactionResponse1 ReportTransactionResponseValue)
        {
            writer.WriteStartElement(null, "RptTxRspn", xmlNamespace );
            ReportTransactionResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReportGetTotalsResponse is ReportGetTotalsResponse1 ReportGetTotalsResponseValue)
        {
            writer.WriteStartElement(null, "RptGetTtlsRspn", xmlNamespace );
            ReportGetTotalsResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Rspn", xmlNamespace );
        Response.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReportResponse2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
