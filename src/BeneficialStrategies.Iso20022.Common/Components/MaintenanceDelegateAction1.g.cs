﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegateAction1.  ISO2002 ID# _sdSxQGp9EeSojYXQbRlLzA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the MTM to build or include delegated actions in the management plan of the POI.
/// </summary>
public partial record MaintenanceDelegateAction1
     : IIsoXmlSerilizable<MaintenanceDelegateAction1>
{
    #nullable enable
    
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    public IsoTrueFalseIndicator? PeriodicAction { get; init; } 
    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    public NetworkParameters3? TMRemoteAccess { get; init; } 
    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocol { get; init; } 
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    public DataSetIdentification4? DataSetIdentification { get; init; } 
    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    public ProcessRetry2? ReTry { get; init; } 
    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    public IsoMax3000Binary? AdditionalInformation { get; init; } 
    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    public TMSAction4? Action { get; init; } 
    
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
        if (PeriodicAction is IsoTrueFalseIndicator PeriodicActionValue)
        {
            writer.WriteStartElement(null, "PrdcActn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(PeriodicActionValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (TMRemoteAccess is NetworkParameters3 TMRemoteAccessValue)
        {
            writer.WriteStartElement(null, "TMRmotAccs", xmlNamespace );
            TMRemoteAccessValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TMSProtocol is IsoMax35Text TMSProtocolValue)
        {
            writer.WriteStartElement(null, "TMSPrtcol", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TMSProtocolValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TMSProtocolVersion is IsoMax35Text TMSProtocolVersionValue)
        {
            writer.WriteStartElement(null, "TMSPrtcolVrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TMSProtocolVersionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DataSetIdentification is DataSetIdentification4 DataSetIdentificationValue)
        {
            writer.WriteStartElement(null, "DataSetId", xmlNamespace );
            DataSetIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReTry is ProcessRetry2 ReTryValue)
        {
            writer.WriteStartElement(null, "ReTry", xmlNamespace );
            ReTryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax3000Binary AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3000Binary(AdditionalInformationValue)); // data type Max3000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (Action is TMSAction4 ActionValue)
        {
            writer.WriteStartElement(null, "Actn", xmlNamespace );
            ActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MaintenanceDelegateAction1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
