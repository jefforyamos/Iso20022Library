﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralCancellationReason1.  ISO2002 ID# _UnhiwNp-Ed-ak6NoX_4Aeg_-540863751.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for which the collateral message has been cancelled.
/// </summary>
public partial record CollateralCancellationReason1
     : IIsoXmlSerilizable<CollateralCancellationReason1>
{
    #nullable enable
    
    /// <summary>
    /// Allows to provides additional information on the cancellation reason.
    /// </summary>
    public IsoMax35Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Allows to provide a cancellation reason using a code or proprietary reason.
    /// </summary>
    public required CollateralCancellationType1Choice_ CancellationReasonCode { get; init; } 
    
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
        if (AdditionalInformation is IsoMax35Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AdditionalInformationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CxlRsnCd", xmlNamespace );
        CancellationReasonCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CollateralCancellationReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
