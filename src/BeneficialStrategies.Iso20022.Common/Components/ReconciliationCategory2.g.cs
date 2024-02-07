﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReconciliationCategory2.  ISO2002 ID# _yeZ-MT6CEe2Z1_pdMHu4SA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies categories of statuses of a derivative when there is no reporting requirement for both counterparties.
/// </summary>
public partial record ReconciliationCategory2
     : IIsoXmlSerilizable<ReconciliationCategory2>
{
    #nullable enable
    
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    public required IsoYesNoIndicator Revived { get; init; } 
    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    public required IsoYesNoIndicator FurtherModification { get; init; } 
    
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
        writer.WriteStartElement(null, "Rvvd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Revived)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FrthrMod", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FurtherModification)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static ReconciliationCategory2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
