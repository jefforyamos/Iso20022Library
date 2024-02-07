﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionProcessingStatus1Choice.  ISO2002 ID# _Q1O85Np-Ed-ak6NoX_4Aeg_-1142477030.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the status of the details of the corporate action event.
/// </summary>
[KnownType(typeof(CorporateActionProcessingStatus1Choice.EventStatus))]
[KnownType(typeof(CorporateActionProcessingStatus1Choice.ForInformationOnlyIndicator))]
public abstract partial record CorporateActionProcessingStatus1Choice_ : IIsoXmlSerilizable<CorporateActionProcessingStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionProcessingStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "EvtSts" => CorporateActionProcessingStatus1Choice.EventStatus.Deserialize(elementWithPayload),
             "ForInfOnlyInd" => CorporateActionProcessingStatus1Choice.ForInformationOnlyIndicator.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionProcessingStatus1Choice choice.")
        };
    }
}
