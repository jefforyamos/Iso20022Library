﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerAlertNotificationStatus1.  ISO2002 ID# _epS_xc78EemEIuVuDudp4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction alert status notification from the tracker.
/// </summary>
public partial record TrackerAlertNotificationStatus1
     : IIsoXmlSerilizable<TrackerAlertNotificationStatus1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of an alert, in a coded form.
    /// </summary>
    public required TrackerAlertStatus1Choice_ AlertStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public TrackerAlertStatusReason1Choice_? StatusReason { get; init; } 
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "AlrtSts", xmlNamespace );
        AlertStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StatusReason is TrackerAlertStatusReason1Choice_ StatusReasonValue)
        {
            writer.WriteStartElement(null, "StsRsn", xmlNamespace );
            StatusReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax105Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(AdditionalInformationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
    }
    public static TrackerAlertNotificationStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
