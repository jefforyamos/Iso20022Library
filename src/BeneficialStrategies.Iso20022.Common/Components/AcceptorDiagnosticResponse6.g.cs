﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorDiagnosticResponse6.  ISO2002 ID# _1xLYYQukEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic response from the acquirer.
/// </summary>
public partial record AcceptorDiagnosticResponse6
     : IIsoXmlSerilizable<AcceptorDiagnosticResponse6>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment74 Environment { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    /// <summary>
    /// Indicates if the acquirer is available.
    /// </summary>
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; } 
    
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
        if (TMSTrigger is TMSTrigger1 TMSTriggerValue)
        {
            writer.WriteStartElement(null, "TMSTrggr", xmlNamespace );
            TMSTriggerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcquirerAvailable is IsoTrueFalseIndicator AcquirerAvailableValue)
        {
            writer.WriteStartElement(null, "AcqrrAvlbl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(AcquirerAvailableValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static AcceptorDiagnosticResponse6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
