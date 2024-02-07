﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldIndicator2.  ISO2002 ID# _sCslEPIqEd-dOvqmSLSz5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the transaction is on hold/blocked/frozen.
/// </summary>
public partial record HoldIndicator2
     : IIsoXmlSerilizable<HoldIndicator2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public required IsoYesNoIndicator Indicator { get; init; } 
    /// <summary>
    /// Specifies the reason of the registration staus.
    /// </summary>
    public RegistrationReason1? Reason { get; init; } 
    
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
        writer.WriteStartElement(null, "Ind", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Indicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (Reason is RegistrationReason1 ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static HoldIndicator2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
