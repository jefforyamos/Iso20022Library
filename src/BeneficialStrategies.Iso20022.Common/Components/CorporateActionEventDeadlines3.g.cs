﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionEventDeadlines3.  ISO2002 ID# _gDEgMbtJEeilsanBGAzy4A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action event deadlines.
/// </summary>
public partial record CorporateActionEventDeadlines3
     : IIsoXmlSerilizable<CorporateActionEventDeadlines3>
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat44Choice_? ResponseDeadline { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    public DateFormat43Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Deadline for protect instructions.
    /// </summary>
    public DateFormat43Choice_? ProtectDeadline { get; init; } 
    /// <summary>
    /// Deadline for covering a protect instruction.
    /// </summary>
    public DateFormat43Choice_? CoverProtectDeadline { get; init; } 
    
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
        if (EarlyResponseDeadline is DateFormat43Choice_ EarlyResponseDeadlineValue)
        {
            writer.WriteStartElement(null, "EarlyRspnDdln", xmlNamespace );
            EarlyResponseDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResponseDeadline is DateFormat44Choice_ ResponseDeadlineValue)
        {
            writer.WriteStartElement(null, "RspnDdln", xmlNamespace );
            ResponseDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketDeadline is DateFormat43Choice_ MarketDeadlineValue)
        {
            writer.WriteStartElement(null, "MktDdln", xmlNamespace );
            MarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectDeadline is DateFormat43Choice_ ProtectDeadlineValue)
        {
            writer.WriteStartElement(null, "PrtctDdln", xmlNamespace );
            ProtectDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CoverProtectDeadline is DateFormat43Choice_ CoverProtectDeadlineValue)
        {
            writer.WriteStartElement(null, "CoverPrtctDdln", xmlNamespace );
            CoverProtectDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionEventDeadlines3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
