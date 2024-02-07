﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Action9.  ISO2002 ID# _B1YNAEXVEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed.
/// </summary>
public partial record Action9
     : IIsoXmlSerilizable<Action9>
{
    #nullable enable
    
    /// <summary>
    /// Destination of the action.
    /// </summary>
    public PartyType20Code? Destination { get; init; } 
    /// <summary>
    /// Action type to be performed.
    /// </summary>
    public ActionType11Code? ActionType { get; init; } 
    /// <summary>
    /// Other action type to be performed.
    /// </summary>
    public IsoMax35Text? OtherActionType { get; init; } 
    /// <summary>
    /// Additional information to the type of action to be performed (for example, channel to be used for additional verification or authentication).
    /// </summary>
    public IsoMax70Text? ActionInformation { get; init; } 
    
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
        if (Destination is PartyType20Code DestinationValue)
        {
            writer.WriteStartElement(null, "Dstn", xmlNamespace );
            writer.WriteValue(DestinationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ActionType is ActionType11Code ActionTypeValue)
        {
            writer.WriteStartElement(null, "ActnTp", xmlNamespace );
            writer.WriteValue(ActionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherActionType is IsoMax35Text OtherActionTypeValue)
        {
            writer.WriteStartElement(null, "OthrActnTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherActionTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ActionInformation is IsoMax70Text ActionInformationValue)
        {
            writer.WriteStartElement(null, "ActnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(ActionInformationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static Action9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
