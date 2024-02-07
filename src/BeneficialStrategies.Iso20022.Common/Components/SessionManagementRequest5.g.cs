﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SessionManagementRequest5.  ISO2002 ID# _gAxp4U6_EeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of Session management service to be used with this message.
/// </summary>
public partial record SessionManagementRequest5
     : IIsoXmlSerilizable<SessionManagementRequest5>
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
    public required RetailerService4Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    public LoginRequest4? LoginRequest { get; init; } 
    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    public LogoutRequest1? LogoutRequest { get; init; } 
    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    public DiagnosisRequest1? DiagnosisRequest { get; init; } 
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
        if (LoginRequest is LoginRequest4 LoginRequestValue)
        {
            writer.WriteStartElement(null, "LgnReq", xmlNamespace );
            LoginRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LogoutRequest is LogoutRequest1 LogoutRequestValue)
        {
            writer.WriteStartElement(null, "LgtReq", xmlNamespace );
            LogoutRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DiagnosisRequest is DiagnosisRequest1 DiagnosisRequestValue)
        {
            writer.WriteStartElement(null, "DgnssReq", xmlNamespace );
            DiagnosisRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SessionManagementRequest5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
