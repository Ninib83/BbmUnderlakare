using EPiServer.Core;
using EPiServer.Find.Cms;
using EPiServer.Find.Cms.Conventions;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Web.Business.Initializations
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class EpiFindIndexingInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ContentIndexer.Instance.Conventions.ForInstancesOf<ContentAssetFolder>().ShouldIndex(x => false);
            ContentIndexer.Instance.Conventions.ForInstancesOf<ContentFolder>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<ContainerPage>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<HeroBlock>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<MediaBlock>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<SettingsPage>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<ArchiveRootPage>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<ProductGroupsBlock>().ShouldIndex(x => false);
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}