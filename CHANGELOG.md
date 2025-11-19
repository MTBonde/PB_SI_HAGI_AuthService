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
