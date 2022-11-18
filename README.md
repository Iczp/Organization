# IczpNet.Organization

a standard abpvnext module

Department,Employee,Functional,Position,PostGrade,PostLevel,PostRank,PostType



## Usage

### DependsOn

Add `DependsOn(typeof(OrganizationXxxModule))` attribute to configure the module dependencies.

- Application


```
[DependsOn(typeof(OrganizationApplicationModule))]
```

-  Application.Contracts

```
[DependsOn(typeof(OrganizationApplicationContractsModule))]
```

-  Domain.Shared

```
[DependsOn(typeof(OrganizationDomainSharedModule))]
```

-  EntityFrameworkCore

```
[DependsOn(typeof(OrganizationEntityFrameworkCoreModule))]
```

-  HttpApi

```
[DependsOn(typeof(OrganizationHttpApiModule))]
```

-  HttpApi.Client

```
[DependsOn(typeof(OrganizationHttpApiClientModule))]
```

-  Installer

```
[DependsOn(typeof(OrganizationInstallerModule))]
```

-  MongoDb

```
[DependsOn(typeof(OrganizationMongoDbModule))]
```

## Internal structure

...