﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Collateral7.  ISO2002 ID# _cvIIYV9-EeSMgPeFpRHeJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral that will be either delivered, returned or both.
/// </summary>
public partial record Collateral7
     : IIsoXmlSerilizable<Collateral7>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    public IsoMax35Text? MarginCallResponseIdentification { get; init; } 
    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; } 
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    public SecuritiesCollateral3? SecuritiesCollateral { get; init; } 
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    public CashCollateral2? CashCollateral { get; init; } 
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    public OtherCollateral2? OtherCollateral { get; init; } 
    
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
        writer.WriteStartElement(null, "MrgnCallReqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MarginCallRequestIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (MarginCallResponseIdentification is IsoMax35Text MarginCallResponseIdentificationValue)
        {
            writer.WriteStartElement(null, "MrgnCallRspnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarginCallResponseIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (StandardSettlementInstructions is IsoMax140Text StandardSettlementInstructionsValue)
        {
            writer.WriteStartElement(null, "StdSttlmInstrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(StandardSettlementInstructionsValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (CollateralProposalResponseIdentification is IsoMax35Text CollateralProposalResponseIdentificationValue)
        {
            writer.WriteStartElement(null, "CollPrpslRspnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralProposalResponseIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesCollateral is SecuritiesCollateral3 SecuritiesCollateralValue)
        {
            writer.WriteStartElement(null, "SctiesColl", xmlNamespace );
            SecuritiesCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashCollateral is CashCollateral2 CashCollateralValue)
        {
            writer.WriteStartElement(null, "CshColl", xmlNamespace );
            CashCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherCollateral is OtherCollateral2 OtherCollateralValue)
        {
            writer.WriteStartElement(null, "OthrColl", xmlNamespace );
            OtherCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Collateral7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
