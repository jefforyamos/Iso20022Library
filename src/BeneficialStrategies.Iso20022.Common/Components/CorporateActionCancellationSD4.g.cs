﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionCancellationSD4.  ISO2002 ID# _s-PqYb5XEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding additional comments.
/// </summary>
public partial record CorporateActionCancellationSD4
     : IIsoXmlSerilizable<CorporateActionCancellationSD4>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Additional textual information regarding the cancelled event.
    /// </summary>
    public IsoMax8000Text? ExternalComments { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (ExternalComments is IsoMax8000Text ExternalCommentsValue)
        {
            writer.WriteStartElement(null, "XtrnlCmnts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8000Text(ExternalCommentsValue)); // data type Max8000Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionCancellationSD4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
