using System;
using System.Collections.Generic;
using MigrationUtils.Dal.Models;

namespace MigrationUtils.Bll.Services
{
    public static class EntitySetUtil
    {
        public static Dictionary<Type, EntityProperties> GetEntityDictionary()
        {
            return new Dictionary<Type, EntityProperties>
            {
                {
                    typeof(ActiveDirectoryUserRole),
                    new EntityProperties("SELECT * FROM [dbo].[ActiveDirectoryUserRoles]",typeof(List<ActiveDirectoryUserRole>))
                },
                {
                    typeof(Broker),
                    new EntityProperties("SELECT * FROM [dbo].[Brokers]",typeof(List<Broker>))
                },
                {
                    typeof(CriticalMilestoneName),
                    new EntityProperties("SELECT * FROM [dbo].[CriticalMilestoneNames]",typeof(List<CriticalMilestoneName>))
                },
                {
                    typeof(CriticalMilestoneProgression),
                    new EntityProperties("SELECT * FROM [dbo].[CriticalMilestoneProgressions]",typeof(List<CriticalMilestoneProgression>))
                },
                {
                    typeof(CriticalMilestone),
                    new EntityProperties("SELECT * FROM [dbo].[CriticalMilestones]",typeof(List<CriticalMilestone>))
                },
                {
                    typeof(CriticalMilestoneSnap),
                    new EntityProperties("SELECT * FROM [dbo].[CriticalMilestoneSnaps]",typeof(List<CriticalMilestoneSnap>))
                },
                {
                    typeof(Customer),
                    new EntityProperties("SELECT * FROM [dbo].[Customers]",typeof(List<Customer>))
                },
                {
                    typeof(CustomerType),
                    new EntityProperties("SELECT * FROM [dbo].[CustomerTypes]",typeof(List<CustomerType>))
                },
                {
                    typeof(DateDimension),
                    new EntityProperties("SELECT * FROM [dbo].[DateDimension]",typeof(List<DateDimension>))
                },
                {
                    typeof(DepartmentType),
                    new EntityProperties("SELECT * FROM [dbo].[DepartmentTypes]",typeof(List<DepartmentType>))
                },
                {
                    typeof(DevelopmentSpendType),
                    new EntityProperties("SELECT * FROM [dbo].[DevelopmentSpendTypes]",typeof(List<DevelopmentSpendType>))
                },
                {
                    typeof(Event),
                    new EntityProperties("SELECT * FROM [dbo].[Events]",typeof(List<Event>))
                },
                {
                    typeof(EventScenario),
                    new EntityProperties("SELECT * FROM [dbo].[EventScenarios]",typeof(List<EventScenario>))
                },
                {
                    typeof(EventSnap),
                    new EntityProperties("SELECT * FROM [dbo].[EventSnaps]",typeof(List<EventSnap>))
                },
                {
                    typeof(EventStatus),
                    new EntityProperties("SELECT * FROM [dbo].[EventStatuses]",typeof(List<EventStatus>))
                },
                {
                    typeof(EventTypeDesignation),
                    new EntityProperties("SELECT * FROM [dbo].[EventTypeDesignations]",typeof(List<EventTypeDesignation>))
                },
                {
                    typeof(EventType),
                    new EntityProperties("SELECT * FROM [dbo].[EventTypes]",typeof(List<EventType>))
                },
                {
                    typeof(ExpenseReport),
                    new EntityProperties("SELECT * FROM [dbo].[ExpenseReports]",typeof(List<ExpenseReport>))
                },
                {
                    typeof(FileMetadata),
                    new EntityProperties("SELECT * FROM [dbo].[FileMetadata]",typeof(List<FileMetadata>))
                },
                {
                    typeof(FinalOutcome),
                    new EntityProperties("SELECT * FROM [dbo].[FinalOutcomes]",typeof(List<FinalOutcome>))
                },
                {
                    typeof(GirStudyWindow),
                    new EntityProperties("SELECT * FROM [dbo].[GirStudyWindows]",typeof(List<GirStudyWindow>))
                },
                {
                    typeof(HolidayDate),
                    new EntityProperties("SELECT * FROM [dbo].[HolidayDates]",typeof(List<HolidayDate>))
                },
                {
                    typeof(Interconnection),
                    new EntityProperties("SELECT * FROM [dbo].[Interconnections]",typeof(List<Interconnection>))
                },
                {
                    typeof(InterconnectionScenario),
                    new EntityProperties("SELECT * FROM [dbo].[InterconnectionScenarios]",typeof(List<InterconnectionScenario>))
                },
                {
                    typeof(InterconnectionSnap),
                    new EntityProperties("SELECT * FROM [dbo].[InterconnectionSnaps]",typeof(List<InterconnectionSnap>))
                },
                {
                    typeof(InterconnectionSpendType),
                    new EntityProperties("SELECT * FROM [dbo].[InterconnectionSpendTypes]",typeof(List<InterconnectionSpendType>))
                },
                {
                    typeof(InterconnectionStatus),
                    new EntityProperties("SELECT * FROM [dbo].[InterconnectionStatuses]",typeof(List<InterconnectionStatus>))
                },
                {
                    typeof(IssuePriorityType),
                    new EntityProperties("SELECT * FROM [dbo].[IssuePriorityTypes]",typeof(List<IssuePriorityType>))
                },
                {
                    typeof(Issue),
                    new EntityProperties("SELECT * FROM [dbo].[Issues]",typeof(List<Issue>))
                },
                {
                    typeof(IssueStatusType),
                    new EntityProperties("SELECT * FROM [dbo].[IssueStatusTypes]",typeof(List<IssueStatusType>))
                },
                {
                    typeof(Label),
                    new EntityProperties("SELECT * FROM [dbo].[Labels]",typeof(List<Label>))
                },
                {
                    typeof(LabelType),
                    new EntityProperties("SELECT * FROM [dbo].[LabelTypes]",typeof(List<LabelType>))
                },
                {
                    typeof(LoginLog),
                    new EntityProperties("SELECT * FROM [dbo].[LoginLogs]",typeof(List<LoginLog>))
                },
                {
                    typeof(Manufacturer),
                    new EntityProperties("SELECT * FROM [dbo].[Manufacturers]",typeof(List<Manufacturer>))
                },
                {
                    typeof(NewStartProjectCriticalMilestone),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjectCriticalMilestones]",typeof(List<NewStartProjectCriticalMilestone>))
                },
                {
                    typeof(NewStartProjectDevelopmentSpend),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjectDevelopmentSpends]",typeof(List<NewStartProjectDevelopmentSpend>))
                },
                {
                    typeof(NewStartProjectInterconnectionSpendStrip),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjectInterconnectionSpendStrips]",typeof(List<NewStartProjectInterconnectionSpendStrip>))
                },
                {
                    typeof(NewStartProjectInterconnectionSpendStripYear),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjectInterconnectionSpendStripYears]",typeof(List<NewStartProjectInterconnectionSpendStripYear>))
                },
                {
                    typeof(NewStartProjectRisk),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjectRisks]",typeof(List<NewStartProjectRisk>))
                },
                {
                    typeof(NewStartProject),
                    new EntityProperties("SELECT * FROM [dbo].[NewStartProjects]",typeof(List<NewStartProject>))
                },
                {
                    typeof(Note),
                    new EntityProperties("SELECT * FROM [dbo].[Notes]",typeof(List<Note>))
                },
                {
                    typeof(NoteSubjectType),
                    new EntityProperties("SELECT * FROM [dbo].[NoteSubjectTypes]",typeof(List<NoteSubjectType>))
                },
                {
                    typeof(PaymentType),
                    new EntityProperties("SELECT * FROM [dbo].[PaymentTypes]",typeof(List<PaymentType>))
                },
                {
                    typeof(PhaseModel),
                    new EntityProperties("SELECT * FROM [dbo].[PhaseModels]",typeof(List<PhaseModel>))
                },
                {
                    typeof(Phase),
                    new EntityProperties("SELECT * FROM [dbo].[Phases]",typeof(List<Phase>))
                },
                {
                    typeof(PortfolioPlanCopy),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanCopies]",typeof(List<PortfolioPlanCopy>))
                },
                {
                    typeof(PortfolioPlanCopyDifference),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanCopyDifferences]",typeof(List<PortfolioPlanCopyDifference>))
                },
                {
                    typeof(PortfolioPlanCopyDifferenceType),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanCopyDifferenceTypes]",typeof(List<PortfolioPlanCopyDifferenceType>))
                },
                {
                    typeof(PortfolioPlanCopyModelType),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanCopyModelTypes]",typeof(List<PortfolioPlanCopyModelType>))
                },
                {
                    typeof(PortfolioPlanCopyStatus),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanCopyStatuses]",typeof(List<PortfolioPlanCopyStatus>))
                },
                {
                    typeof(PortfolioPlanNewStartProject),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanNewStartProjects]",typeof(List<PortfolioPlanNewStartProject>))
                },
                {
                    typeof(PortfolioPlanProjectSnap),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanProjectSnaps]",typeof(List<PortfolioPlanProjectSnap>))
                },
                {
                    typeof(PortfolioPlan),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlans]",typeof(List<PortfolioPlan>))
                },
                {
                    typeof(PortfolioPlanScheduleEntry),
                    new EntityProperties("SELECT * FROM [dbo].[PortfolioPlanScheduleEntries]",typeof(List<PortfolioPlanScheduleEntry>))
                },
                {
                    typeof(PowerBiReport),
                    new EntityProperties("SELECT * FROM [dbo].[PowerBiReports]",typeof(List<PowerBiReport>))
                },
                {
                    typeof(PowerBiReportType),
                    new EntityProperties("SELECT * FROM [dbo].[PowerBiReportTypes]",typeof(List<PowerBiReportType>))
                },
                {
                    typeof(ProjectBusinessDevelopmentStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectBusinessDevelopmentStatuses]",typeof(List<ProjectBusinessDevelopmentStatus>))
                },
                {
                    typeof(ProjectLlcFilingState),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectLlcFilingStates]",typeof(List<ProjectLlcFilingState>))
                },
                {
                    typeof(ProjectLlcFilingStateStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectLlcFilingStateStatuses]",typeof(List<ProjectLlcFilingStateStatus>))
                },
                {
                    typeof(ProjectLlcFilingStateType),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectLlcFilingStateTypes]",typeof(List<ProjectLlcFilingStateType>))
                },
                {
                    typeof(ProjectLlc),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectLlcs]",typeof(List<ProjectLlc>))
                },
                {
                    typeof(ProjectLlcStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectLlcStatuses]",typeof(List<ProjectLlcStatus>))
                },
                {
                    typeof(ProjectMilestoneGroup),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectMilestoneGroups]",typeof(List<ProjectMilestoneGroup>))
                },
                {
                    typeof(ProjectMilestoneName),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectMilestoneNames]",typeof(List<ProjectMilestoneName>))
                },
                {
                    typeof(ProjectMilestoneProgression),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectMilestoneProgressions]",typeof(List<ProjectMilestoneProgression>))
                },
                {
                    typeof(ProjectMilestone),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectMilestones]",typeof(List<ProjectMilestone>))
                },
                {
                    typeof(ProjectNameLog),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectNameLogs]",typeof(List<ProjectNameLog>))
                },
                {
                    typeof(ProjectPriorityStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectPriorityStatuses]",typeof(List<ProjectPriorityStatus>))
                },
                {
                    typeof(ProjectRegionalTransmissionOwner),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectRegionalTransmissionOwners]",typeof(List<ProjectRegionalTransmissionOwner>))
                },
                {
                    typeof(ProjectRiskCategory),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectRiskCategories]",typeof(List<ProjectRiskCategory>))
                },
                {
                    typeof(ProjectRiskLevel),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectRiskLevels]",typeof(List<ProjectRiskLevel>))
                },
                {
                    typeof(ProjectRisk),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectRisks]",typeof(List<ProjectRisk>))
                },
                {
                    typeof(Project),
                    new EntityProperties("SELECT * FROM [dbo].[Projects]",typeof(List<Project>))
                },
                {
                    typeof(ProjectSnapDevelopmentSpend),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectSnapDevelopmentSpends]",typeof(List<ProjectSnapDevelopmentSpend>))
                },
                {
                    typeof(ProjectSnapInterconnectionSpendStrip),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectSnapInterconnectionSpendStrips]",typeof(List<ProjectSnapInterconnectionSpendStrip>))
                },
                {
                    typeof(ProjectSnapInterconnectionSpendStripYear),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectSnapInterconnectionSpendStripYears]",typeof(List<ProjectSnapInterconnectionSpendStripYear>))
                },
                {
                    typeof(ProjectSnap),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectSnaps]",typeof(List<ProjectSnap>))
                },
                {
                    typeof(ProjectStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectStatuses]",typeof(List<ProjectStatus>))
                },
                {
                    typeof(ProjectTeamMember),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectTeamMembers]",typeof(List<ProjectTeamMember>))
                },
                {
                    typeof(ProjectTeamRole),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectTeamRoles]",typeof(List<ProjectTeamRole>))
                },
                {
                    typeof(ProjectType),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectTypes]",typeof(List<ProjectType>))
                },
                {
                    typeof(ProjectWriteUp),
                    new EntityProperties("SELECT * FROM [dbo].[ProjectWriteUps]",typeof(List<ProjectWriteUp>))
                },
                {
                    typeof(ProposalBid),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalBids]",typeof(List<ProposalBid>))
                },
                {
                    typeof(ProposalBidType),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalBidTypes]",typeof(List<ProposalBidType>))
                },
                {
                    typeof(ProposalGroup),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalGroups]",typeof(List<ProposalGroup>))
                },
                {
                    typeof(ProposalGroupStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalGroupStatuses]",typeof(List<ProposalGroupStatus>))
                },
                {
                    typeof(ProposalGroupTask),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalGroupTasks]",typeof(List<ProposalGroupTask>))
                },
                {
                    typeof(ProposalGroupTaskType),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalGroupTaskTypes]",typeof(List<ProposalGroupTaskType>))
                },
                {
                    typeof(ProposalGroupType),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalGroupTypes]",typeof(List<ProposalGroupType>))
                },
                {
                    typeof(Proposal),
                    new EntityProperties("SELECT * FROM [dbo].[Proposals]",typeof(List<Proposal>))
                },
                {
                    typeof(ProposalStatus),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalStatuses]",typeof(List<ProposalStatus>))
                },
                {
                    typeof(ProposalWriteUp),
                    new EntityProperties("SELECT * FROM [dbo].[ProposalWriteUps]",typeof(List<ProposalWriteUp>))
                },
                {
                    typeof(PwaProjectSnap),
                    new EntityProperties("SELECT * FROM [dbo].[PwaProjectSnaps]",typeof(List<PwaProjectSnap>))
                },
                {
                    typeof(PwaSnap),
                    new EntityProperties("SELECT * FROM [dbo].[PwaSnaps]",typeof(List<PwaSnap>))
                },
                {
                    typeof(RateOfRefundabilityValue),
                    new EntityProperties("SELECT * FROM [dbo].[RateOfRefundabilityValues]",typeof(List<RateOfRefundabilityValue>))
                },
                {
                    typeof(RefundSchedule),
                    new EntityProperties("SELECT * FROM [dbo].[RefundSchedules]",typeof(List<RefundSchedule>))
                },
                {
                    typeof(Region),
                    new EntityProperties("SELECT * FROM [dbo].[Regions]",typeof(List<Region>))
                },
                {
                    typeof(ResourceDesignationType),
                    new EntityProperties("SELECT * FROM [dbo].[ResourceDesignationTypes]",typeof(List<ResourceDesignationType>))
                },
                {
                    typeof(ResourceType),
                    new EntityProperties("SELECT * FROM [dbo].[ResourceTypes]",typeof(List<ResourceType>))
                },
                {
                    typeof(SchemaVersion),
                    new EntityProperties("SELECT * FROM [dbo].[SchemaVersions]",typeof(List<SchemaVersion>))
                },
                {
                    typeof(Snap),
                    new EntityProperties("SELECT * FROM [dbo].[Snaps]",typeof(List<Snap>))
                },
                {
                    typeof(SnapStatusType),
                    new EntityProperties("SELECT * FROM [dbo].[SnapStatusTypes]",typeof(List<SnapStatusType>))
                },
                {
                    typeof(StateReportFiling),
                    new EntityProperties("SELECT * FROM [dbo].[StateReportFilings]",typeof(List<StateReportFiling>))
                },
                {
                    typeof(StateReportFirstDueDateRule),
                    new EntityProperties("SELECT * FROM [dbo].[StateReportFirstDueDateRules]",typeof(List<StateReportFirstDueDateRule>))
                },
                {
                    typeof(StateReportInterval),
                    new EntityProperties("SELECT * FROM [dbo].[StateReportIntervals]",typeof(List<StateReportInterval>))
                },
                {
                    typeof(StateReportName),
                    new EntityProperties("SELECT * FROM [dbo].[StateReportNames]",typeof(List<StateReportName>))
                },
                {
                    typeof(StateReportTemplate),
                    new EntityProperties("SELECT * FROM [dbo].[StateReportTemplates]",typeof(List<StateReportTemplate>))
                },
                {
                    typeof(State),
                    new EntityProperties("SELECT * FROM [dbo].[States]",typeof(List<State>))
                },
                {
                    typeof(SubEventAlertPriority),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventAlertPriorities]",typeof(List<SubEventAlertPriority>))
                },
                {
                    typeof(SubEventAlert),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventAlerts]",typeof(List<SubEventAlert>))
                },
                {
                    typeof(SubEventAlertType),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventAlertTypes]",typeof(List<SubEventAlertType>))
                },
                {
                    typeof(SubEventConnection),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventConnections]",typeof(List<SubEventConnection>))
                },
                {
                    typeof(SubEventIssuePriority),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventIssuePriorities]",typeof(List<SubEventIssuePriority>))
                },
                {
                    typeof(SubEventName),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventNames]",typeof(List<SubEventName>))
                },
                {
                    typeof(SubEvent),
                    new EntityProperties("SELECT * FROM [dbo].[SubEvents]",typeof(List<SubEvent>))
                },
                {
                    typeof(SubEventScenarioConnection),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventScenarioConnections]",typeof(List<SubEventScenarioConnection>))
                },
                {
                    typeof(SubEventScenario),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventScenarios]",typeof(List<SubEventScenario>))
                },
                {
                    typeof(SubEventSnap),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventSnaps]",typeof(List<SubEventSnap>))
                },
                {
                    typeof(SubEventStatus),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventStatuses]",typeof(List<SubEventStatus>))
                },
                {
                    typeof(SubEventTemplate),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventTemplates]",typeof(List<SubEventTemplate>))
                },
                {
                    typeof(SubEventType),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventTypes]",typeof(List<SubEventType>))
                },
                {
                    typeof(SubEventTypeSnap),
                    new EntityProperties("SELECT * FROM [dbo].[SubEventTypeSnaps]",typeof(List<SubEventTypeSnap>))
                },
                {
                    typeof(Swot),
                    new EntityProperties("SELECT * FROM [dbo].[Swots]",typeof(List<Swot>))
                },
                {
                    typeof(SwotType),
                    new EntityProperties("SELECT * FROM [dbo].[SwotTypes]",typeof(List<SwotType>))
                },
                {
                    typeof(TransmissionEntity),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntities]",typeof(List<TransmissionEntity>))
                },
                {
                    typeof(TransmissionEntityEventType),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntityEventTypes]",typeof(List<TransmissionEntityEventType>))
                },
                {
                    typeof(TransmissionEntityEventTypeSnap),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntityEventTypeSnaps]",typeof(List<TransmissionEntityEventTypeSnap>))
                },
                {
                    typeof(TransmissionEntityGroup),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntityGroups]",typeof(List<TransmissionEntityGroup>))
                },
                {
                    typeof(TransmissionEntitySnap),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntitySnaps]",typeof(List<TransmissionEntitySnap>))
                },
                {
                    typeof(TransmissionEntityTemplate),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionEntityTemplates]",typeof(List<TransmissionEntityTemplate>))
                },
                {
                    typeof(TransmissionOwnerType),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionOwnerTypes]",typeof(List<TransmissionOwnerType>))
                },
                {
                    typeof(TransmissionProviderType),
                    new EntityProperties("SELECT * FROM [dbo].[TransmissionProviderTypes]",typeof(List<TransmissionProviderType>))
                },
                {
                    typeof(UpgradeCostResourceDesignationType),
                    new EntityProperties("SELECT * FROM [dbo].[UpgradeCostResourceDesignationTypes]",typeof(List<UpgradeCostResourceDesignationType>))
                },
                {
                    typeof(UpgradeCost),
                    new EntityProperties("SELECT * FROM [dbo].[UpgradeCosts]",typeof(List<UpgradeCost>))
                },
                {
                    typeof(UpgradeCostTransmissionEntity),
                    new EntityProperties("SELECT * FROM [dbo].[UpgradeCostTransmissionEntities]",typeof(List<UpgradeCostTransmissionEntity>))
                },
                {
                    typeof(UpgradeCostType),
                    new EntityProperties("SELECT * FROM [dbo].[UpgradeCostTypes]",typeof(List<UpgradeCostType>))
                },
                {
                    typeof(UserInformation),
                    new EntityProperties("SELECT * FROM [dbo].[UserInformation]",typeof(List<UserInformation>))
                }
            };
        }

        public class EntityProperties
        {
            public EntityProperties(string getCommand, Type listType)
            {
                GetCommand = getCommand;
                ListType = listType;
            }

            public string GetCommand { get; set; }
            public Type ListType { get; set; }
        }
    }
}