﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferOut13.  ISO2002 ID# _Xr92oS74EeO59oUFO5eLvw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer out transaction.
/// </summary>
public partial record TransferOut13
     : IIsoXmlSerilizable<TransferOut13>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer27? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _wYHnUS74EeO59oUFO5eLvw
    
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
        if (CancellationReference is IsoMax35Text CancellationReferenceValue)
        {
            writer.WriteStartElement(null, "CxlRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize TransferDetails, multiplicity Unknown
    }
    public static TransferOut13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
