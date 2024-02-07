﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ErrorAction2.  ISO2002 ID# _FeJ-kR3ZEeKKrOIoqWglDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform in case of error on the related action in progress.
/// </summary>
public partial record ErrorAction2
     : IIsoXmlSerilizable<ErrorAction2>
{
    #nullable enable
    
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    public TerminalManagementActionResult1Code? ActionResult { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _FqWngR3ZEeKKrOIoqWglDw
    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; } 
    
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
        // Not sure how to serialize ActionResult, multiplicity Unknown
        writer.WriteStartElement(null, "ActnToPrc", xmlNamespace );
        writer.WriteValue(ActionToProcess.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static ErrorAction2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
