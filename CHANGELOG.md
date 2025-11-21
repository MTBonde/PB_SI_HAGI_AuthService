## 0.5.16 (2025-11-21)

#### Bug Fixes

* **ci:** adjust Docker build context in CD workflow (202ca137)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.15 [skip ci] (1c0d3fca)


## 0.5.15 (2025-11-21)

#### Bug Fixes

* **ci:** enable manual triggering and automate CD workflow from Semantic release (f7b5c58c)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.14 [skip ci] (bf03e102)


## 0.5.14 (2025-11-21)

#### Bug Fixes

* **ci:** simplify semantic release workflow by removing PR creation for version updates (3da1bd07)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.13 [skip ci] (ab7dcdf7)


## 0.5.13 (2025-11-21)

#### Bug Fixes

* **ci:** improve reliability of auto-merge for version update PRs (092fede6)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.12 [skip ci] (77ffd976)


## 0.5.12 (2025-11-21)

#### Bug Fixes

* **ci:** enable admin override for auto-merging version update PRs (8047883a)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.11 [skip ci] (#18) (aa4f2b83)


## 0.5.11 (2025-11-21)

#### Bug Fixes

* try again now aut merge allowed in settings (e1b19417)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.10 [skip ci] (cba02178)


## 0.5.10 (2025-11-21)

#### Bug Fixes

* try again (3a35ddff)


## 0.5.6 (2025-11-19)

#### Bug Fixes

* **ci:** add workflow_dispatch trigger to CD and pass version input (fefa2234)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.5 [skip ci] (2feb117c)


## 0.5.5 (2025-11-19)

#### Bug Fixes

* **ci:** add actions write permission to trigger CD workflow (aafc04cc)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.4 [skip ci] (4cbbbe64)


## 0.5.4 (2025-11-19)

#### Bug Fixes

* **ci:** trigger CD workflow after semantic release completes (f20547f8)

#### Chores

* update CHANGELOG.md and version.txt for 0.5.3 [skip ci] (62a9fd9b)


## 0.5.3 (2025-11-19)

#### Bug Fixes

* **ci:** use head_branch instead of head_sha to avoid detached HEAD (2bda483b)


## 0.5.1 (2025-11-19)

#### Bug Fixes

* **ci:** ensure semantic release only runs after CI passes (5f89f5de)

#### Chores

* **ci:** rename workflow to "Semantic Release" for clarity (ef5b90ec)
* **docker:** update Dockerfile and workflows to handle versioning via version.txt (0567addc)


## 0.5.0 (2025-11-19)

#### Feature

* **ci:** integrate semantic versioning with automated releases (a6ed7483)


## 0.4.0 (2025-01-19)

#### Features

* add HAGI.Robust package for resilience, readiness endpoint, and dependency checking

## 0.3.0 (2025-01-18)

#### Features

* add more claims support to JWT tokens
* Auth 3.0 improvements

## 0.2.0 (2025-01-17)

#### Features

* implement basic authentication functionality
* add JWT token creation and validation
* add login and logout endpoints

#### Bug Fixes

* fix secret key handling

## 0.1.0 (2025-01-16)

#### Features

* initial walking skeleton implementation
* add Docker support and CI/CD workflows
* set up core AuthService functionality with REST endpoints and versioning
