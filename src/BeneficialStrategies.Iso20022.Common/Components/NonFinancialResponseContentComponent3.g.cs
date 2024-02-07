﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialResponseContentComponent3.  ISO2002 ID# _JlplIXJNEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial response.
/// </summary>
public partial record NonFinancialResponseContentComponent3
     : IIsoXmlSerilizable<NonFinancialResponseContentComponent3>
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    public required NonFinancialRequestType2Code NonFinancialRequestType { get; init; } 
    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    public Acquirer10? AcquirerSelected { get; init; } 
    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk. 
    /// </summary>
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    /// <summary>
    /// Details of instalment supoported by the Service Provider.
    /// </summary>
    public RecurringTransaction5? Instalment { get; init; } 
    /// <summary>
    /// Additional elements sent by the ServiceProvider which are not linked to payment.
    /// </summary>
    public ExternallyDefinedData4? AdditionalResponse { get; init; } 
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public Action14? Action { get; init; } 
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType11 Response { get; init; } 
    
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
        writer.WriteStartElement(null, "NonFinReqTp", xmlNamespace );
        writer.WriteValue(NonFinancialRequestType.ToString()); // Enum value
        writer.WriteEndElement();
        if (AcquirerSelected is Acquirer10 AcquirerSelectedValue)
        {
            writer.WriteStartElement(null, "AcqrrSelctd", xmlNamespace );
            AcquirerSelectedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RiskManagementResult is NonFinancialResponseRisk1Code RiskManagementResultValue)
        {
            writer.WriteStartElement(null, "RskMgmtRslt", xmlNamespace );
            writer.WriteValue(RiskManagementResultValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Instalment is RecurringTransaction5 InstalmentValue)
        {
            writer.WriteStartElement(null, "Instlmt", xmlNamespace );
            InstalmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalResponse is ExternallyDefinedData4 AdditionalResponseValue)
        {
            writer.WriteStartElement(null, "AddtlRspn", xmlNamespace );
            AdditionalResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Action is Action14 ActionValue)
        {
            writer.WriteStartElement(null, "Actn", xmlNamespace );
            ActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Rspn", xmlNamespace );
        Response.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static NonFinancialResponseContentComponent3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
