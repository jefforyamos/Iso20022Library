﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResultData1.  ISO2002 ID# _ZMAxsEXUEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the processing.
/// </summary>
public partial record ResultData1
     : IIsoXmlSerilizable<ResultData1>
{
    #nullable enable
    
    /// <summary>
    /// Generic result of the processing.
    /// ISO 8583 bit 39
    /// </summary>
    public Response8Code? Result { get; init; } 
    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    public IsoMax35Text? OtherResult { get; init; } 
    /// <summary>
    /// Detailed results of the processing.
    /// ISO 8583:1987 bit 39, response code list
    /// </summary>
    public required IsoExact2AlphaNumericText ResultDetails { get; init; } 
    /// <summary>
    /// Other result details of the processing.
    /// </summary>
    public IsoMax35Text? OtherResultDetails { get; init; } 
    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    public AdditionalData1? AdditionalResultInformation { get; init; } 
    
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
        if (Result is Response8Code ResultValue)
        {
            writer.WriteStartElement(null, "Rslt", xmlNamespace );
            writer.WriteValue(ResultValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherResult is IsoMax35Text OtherResultValue)
        {
            writer.WriteStartElement(null, "OthrRslt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherResultValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RsltDtls", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact2AlphaNumericText(ResultDetails)); // data type Exact2AlphaNumericText System.String
        writer.WriteEndElement();
        if (OtherResultDetails is IsoMax35Text OtherResultDetailsValue)
        {
            writer.WriteStartElement(null, "OthrRsltDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherResultDetailsValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalResultInformation is AdditionalData1 AdditionalResultInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsltInf", xmlNamespace );
            AdditionalResultInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ResultData1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
