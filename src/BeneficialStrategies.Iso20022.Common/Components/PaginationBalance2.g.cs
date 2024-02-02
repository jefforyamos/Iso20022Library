﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaginationBalance2.  ISO2002 ID# _s56c4QgGEeSxsfb1OEDVsw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance of a financial instrument for a specific statement page.
/// </summary>
[DataContract]
[XmlType]
public partial record PaginationBalance2
{
    #nullable enable
    
    /// <summary>
    /// Opening balance of the financial instrument in the statement or of the intermediary opening balance of the page of the statement.
    /// </summary>
    [DataMember]
    public OpeningBalance3Choice_? OpeningBalance { get; init; } 
    /// <summary>
    /// Closing balance of the financial instrument in the statement or of the intermediary closing balance of the page of the statement.
    /// </summary>
    [DataMember]
    public ClosingBalance3Choice_? ClosingBalance { get; init; } 
    
    #nullable disable
}
