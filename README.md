<<<<<<< HEAD




<!DOCTYPE html>
<html lang="en" class=" is-copy-enabled">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta name="viewport" content="width=1020">
    
    
    <title>ServoController/README.md at master · cterraza/ServoController</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="cterraza/ServoController" name="twitter:title" /><meta content="ServoController - Firmware y software para control de servos hasta 18 canales con atmega328" name="twitter:description" /><meta content="https://avatars1.githubusercontent.com/u/10850282?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars1.githubusercontent.com/u/10850282?v=3&amp;s=400" property="og:image" /><meta content="cterraza/ServoController" property="og:title" /><meta content="https://github.com/cterraza/ServoController" property="og:url" /><meta content="ServoController - Firmware y software para control de servos hasta 18 canales con atmega328" property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/MTA4NTAyODI6MDY2MjM0YmVlMDE4ZWU2MTYwNjNjZmU0ODRmOTZkN2Q6YTczYWU5NTg5MDZkZDQyNjNhOWFhMDBiMTk3ZTUyMTY0NWI3MmVjMGI2YWU2YWYwYjNhZmVhZjM3N2JjNDEzOA==--85896992852d11b5e6a2de202334d9520f673c67">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>

    <meta name="google-site-verification" content="KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU">
    <meta name="google-analytics" content="UA-3769691-2">

<meta content="collector.githubapp.com" name="octolytics-host" /><meta content="github" name="octolytics-app-id" /><meta content="BA1EAEBA:19DA:840BDB9:565B30FA" name="octolytics-dimension-request_id" /><meta content="10850282" name="octolytics-actor-id" /><meta content="cterraza" name="octolytics-actor-login" /><meta content="0dc53dd958d5c9eb565aa2ab72197b73f452e48bcf1bd99fb2d64ec62b700820" name="octolytics-actor-hash" />
<meta content="/&lt;user-name&gt;/&lt;repo-name&gt;/blob/show" data-pjax-transient="true" name="analytics-location" />
<meta content="Rails, view, blob#show" data-pjax-transient="true" name="analytics-event" />


  <meta class="js-ga-set" name="dimension1" content="Logged In">
    <meta class="js-ga-set" name="dimension4" content="New repo nav">




    <meta name="is-dotcom" content="true">
        <meta name="hostname" content="github.com">
    <meta name="user-login" content="cterraza">

      <link rel="mask-icon" href="https://assets-cdn.github.com/pinned-octocat.svg" color="#4078c0">
      <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">

    <meta content="fc40be865cb61b3c17580c5788ae02d822d379a0" name="form-nonce" />

    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github-3698fb0adc53fda9a2672a02c3fa3b20b89480f2a47ce38216b21cf3eb5b4750.css" integrity="sha256-Npj7CtxT/amiZyoCw/o7ILiUgPKkfOOCFrIc8+tbR1A=" media="all" rel="stylesheet" />
    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github2-912fc0b3ba75b656d2d1687e8be122647344ab57d955de8f6635ee88161cf450.css" integrity="sha256-kS/As7p1tlbS0Wh+i+EiZHNEq1fZVd6PZjXuiBYc9FA=" media="all" rel="stylesheet" />
    
    
    


    <meta http-equiv="x-pjax-version" content="ea5f350928a02058c50a6aed5b15b966">

      
  <meta name="description" content="ServoController - Firmware y software para control de servos hasta 18 canales con atmega328">
  <meta name="go-import" content="github.com/cterraza/ServoController git https://github.com/cterraza/ServoController.git">

  <meta content="10850282" name="octolytics-dimension-user_id" /><meta content="cterraza" name="octolytics-dimension-user_login" /><meta content="47070929" name="octolytics-dimension-repository_id" /><meta content="cterraza/ServoController" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="47070929" name="octolytics-dimension-repository_network_root_id" /><meta content="cterraza/ServoController" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/cterraza/ServoController/commits/master.atom" rel="alternate" title="Recent Commits to ServoController:master" type="application/atom+xml">

  </head>


  <body class="logged_in   env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>

    
    
    



      <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/cterraza/ServoController/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <label class="js-chromeless-input-container form-control">
    <div class="scope-badge">This repository</div>
    <input type="text"
      class="js-site-search-focus js-site-search-field is-clearable chromeless-input"
      data-hotkey="s"
      name="q"
      placeholder="Search"
      aria-label="Search this repository"
      data-global-scope-placeholder="Search GitHub"
      data-repo-scope-placeholder="Search"
      tabindex="1"
      autocapitalize="off">
  </label>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item">
          <a href="/pulls" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:pulls context:user" data-hotkey="g p" data-selected-links="/pulls /pulls/assigned /pulls/mentioned /pulls">
            Pull requests
</a>        </li>
        <li class="header-nav-item">
          <a href="/issues" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:issues context:user" data-hotkey="g i" data-selected-links="/issues /issues/assigned /issues/mentioned /issues">
            Issues
</a>        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com/" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item">
      <span class="js-socket-channel js-updatable-content"
        data-channel="notification-changed:cterraza"
        data-url="/notifications/header">
      <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
          <span class="mail-status all-read"></span>
          <span class="octicon octicon-bell"></span>
</a>  </span>

  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link tooltipped tooltipped-s js-menu-target" href="/new"
       aria-label="Create new…"
       data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus left"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu dropdown-menu-sw">
        
<a class="dropdown-item" href="/new" data-ga-click="Header, create new repository">
  New repository
</a>


  <a class="dropdown-item" href="/organizations/new" data-ga-click="Header, create new organization">
    New organization
  </a>



  <div class="dropdown-divider"></div>
  <div class="dropdown-header">
    <span title="cterraza/ServoController">This repository</span>
  </div>
    <a class="dropdown-item" href="/cterraza/ServoController/issues/new" data-ga-click="Header, create new issue">
      New issue
    </a>
    <a class="dropdown-item" href="/cterraza/ServoController/settings/collaboration" data-ga-click="Header, create new collaborator">
      New collaborator
    </a>

      </ul>
    </div>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name tooltipped tooltipped-s js-menu-target" href="/cterraza"
       aria-label="View profile and more"
       data-ga-click="Header, show menu, icon:avatar">
      <img alt="@cterraza" class="avatar" height="20" src="https://avatars0.githubusercontent.com/u/10850282?v=3&amp;s=40" width="20" />
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <div class="dropdown-menu  dropdown-menu-sw">
        <div class=" dropdown-header header-nav-current-user css-truncate">
            Signed in as <strong class="css-truncate-target">cterraza</strong>

        </div>


        <div class="dropdown-divider"></div>

          <a class="dropdown-item" href="/cterraza" data-ga-click="Header, go to profile, text:your profile">
            Your profile
          </a>
        <a class="dropdown-item" href="/stars" data-ga-click="Header, go to starred repos, text:your stars">
          Your stars
        </a>
        <a class="dropdown-item" href="/explore" data-ga-click="Header, go to explore, text:explore">
          Explore
        </a>
          <a class="dropdown-item" href="/integrations" data-ga-click="Header, go to integrations, text:integrations">
            Integrations
          </a>
        <a class="dropdown-item" href="https://help.github.com" data-ga-click="Header, go to help, text:help">
          Help
        </a>

          <div class="dropdown-divider"></div>

          <a class="dropdown-item" href="/settings/profile" data-ga-click="Header, go to settings, icon:settings">
            Settings
          </a>

          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/logout" class="logout-form" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="xcIT2/Z6Jj7SDfELyvAI3VQBRkZmLimEdjmE2qIHRyYmnCV3YuUkC81KI5ZJoSbqS6sA5Su0C4X6mb/zQ3gG9g==" /></div>
            <button class="dropdown-item dropdown-signout" data-ga-click="Header, sign out, icon:logout">
              Sign out
            </button>
</form>
      </div>
    </div>
  </li>
</ul>


    
  </div>
</div>

      

      


    <div id="start-of-content" class="accessibility-aid"></div>

    <div id="js-flash-container">
</div>


    <div role="main" class="main-content">
        <div itemscope itemtype="http://schema.org/WebPage">
    <div id="js-repo-pjax-container" class="context-loader-container js-repo-nav-next" data-pjax-container>
      
<div class="pagehead repohead instapaper_ignore readability-menu experiment-repo-nav">
  <div class="container repohead-details-container">

    

<ul class="pagehead-actions">

  <li>
        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="13Szf82Nkjxztuvp75D5sf36/7d2r5CCLcdiitLQdx0wtmp3c/8UV24Z9t+GpJhUAu3vtqY9Z4rdGppgDlrR4A==" /></div>      <input id="repository_id" name="repository_id" type="hidden" value="47070929" />

        <div class="select-menu js-menu-container js-select-menu">
          <a href="/cterraza/ServoController/subscription"
            class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
            data-ga-click="Repository, click Watch settings, action:blob#show">
            <span class="js-select-button">
              <span class="octicon octicon-eye"></span>
              Unwatch
            </span>
          </a>
          <a class="social-count js-social-count" href="/cterraza/ServoController/watchers">
            1
          </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
              <span class="select-menu-title">Notifications</span>
            </div>

              <div class="select-menu-list js-navigation-container" role="menu">

                <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                  <span class="select-menu-item-icon octicon octicon-check"></span>
                  <div class="select-menu-item-text">
                    <input id="do_included" name="do" type="radio" value="included" />
                    <span class="select-menu-item-heading">Not watching</span>
                    <span class="description">Be notified when participating or @mentioned.</span>
                    <span class="js-select-button-text hidden-select-button-text">
                      <span class="octicon octicon-eye"></span>
                      Watch
                    </span>
                  </div>
                </div>

                <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                  <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                  <div class="select-menu-item-text">
                    <input checked="checked" id="do_subscribed" name="do" type="radio" value="subscribed" />
                    <span class="select-menu-item-heading">Watching</span>
                    <span class="description">Be notified of all conversations.</span>
                    <span class="js-select-button-text hidden-select-button-text">
                      <span class="octicon octicon-eye"></span>
                      Unwatch
                    </span>
                  </div>
                </div>

                <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                  <span class="select-menu-item-icon octicon octicon-check"></span>
                  <div class="select-menu-item-text">
                    <input id="do_ignore" name="do" type="radio" value="ignore" />
                    <span class="select-menu-item-heading">Ignoring</span>
                    <span class="description">Never be notified.</span>
                    <span class="js-select-button-text hidden-select-button-text">
                      <span class="octicon octicon-mute"></span>
                      Stop ignoring
                    </span>
                  </div>
                </div>

              </div>

            </div>
          </div>
        </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/unstar" class="js-toggler-form starred js-unstar-button" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ekzEZzWvKuaPolJcbdzBUHgC64mN1gZtJZzLx6+MTjV2mwv6svUxobHCPdMOkRN6cubs/tpJIOOMyh/ZmNHqvg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar cterraza/ServoController"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/cterraza/ServoController/stargazers">
          0
        </a>
</form>
    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/star" class="js-toggler-form unstarred js-star-button" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="n6PO8qR6g0QYWQNLM4QPjVaaK3U1hX2GzBI75n5A57EPupE5QiOK8YZk+05bDFGCxg8vKyUEIMdvpsBR33bIvA==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star cterraza/ServoController"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/cterraza/ServoController/stargazers">
          0
        </a>
</form>  </div>

  </li>

  <li>
          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/fork" class="btn-with-count" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="g/Mk6BrmIHE3W8yEdztVMYBWLKAxyq/oQmxZBBihTzwpANXGYj0PUFu3TDtGJTh6HaY+z9MhTDVWBeE4ekXkHA==" /></div>
            <button
                type="submit"
                class="btn btn-sm btn-with-count"
                data-ga-click="Repository, show fork modal, action:blob#show; text:Fork"
                title="Fork your own copy of cterraza/ServoController to your account"
                aria-label="Fork your own copy of cterraza/ServoController to your account">
              <span class="octicon octicon-repo-forked"></span>
              Fork
            </button>
</form>
    <a href="/cterraza/ServoController/network" class="social-count">
      0
    </a>
  </li>
</ul>

    <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public ">
  <span class="octicon octicon-repo"></span>
  <span class="author"><a href="/cterraza" class="url fn" itemprop="url" rel="author"><span itemprop="title">cterraza</span></a></span><!--
--><span class="path-divider">/</span><!--
--><strong><a href="/cterraza/ServoController" data-pjax="#js-repo-pjax-container">ServoController</a></strong>

  <span class="page-context-loader">
    <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
  </span>

</h1>

  </div>
  <div class="container">
    
<nav class="reponav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/cterraza/ServoController/issues/counts">

  <a href="/cterraza/ServoController" aria-label="Code" aria-selected="true" class="js-selected-navigation-item selected reponav-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /cterraza/ServoController">
    <span class="octicon octicon-code"></span>
    Code
</a>
    <a href="/cterraza/ServoController/issues" class="js-selected-navigation-item reponav-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /cterraza/ServoController/issues">
      <span class="octicon octicon-issue-opened"></span>
      Issues
      <span class="counter">0</span>

</a>
  <a href="/cterraza/ServoController/pulls" class="js-selected-navigation-item reponav-item" data-hotkey="g p" data-selected-links="repo_pulls /cterraza/ServoController/pulls">
    <span class="octicon octicon-git-pull-request"></span>
    Pull requests
    <span class="counter">0</span>

</a>
    <a href="/cterraza/ServoController/wiki" class="js-selected-navigation-item reponav-item" data-hotkey="g w" data-selected-links="repo_wiki /cterraza/ServoController/wiki">
      <span class="octicon octicon-book"></span>
      Wiki
</a>
  <a href="/cterraza/ServoController/pulse" class="js-selected-navigation-item reponav-item" data-selected-links="pulse /cterraza/ServoController/pulse">
    <span class="octicon octicon-pulse"></span>
    Pulse
</a>
  <a href="/cterraza/ServoController/graphs" class="js-selected-navigation-item reponav-item" data-selected-links="repo_graphs repo_contributors /cterraza/ServoController/graphs">
    <span class="octicon octicon-graph"></span>
    Graphs
</a>
    <a href="/cterraza/ServoController/settings" class="js-selected-navigation-item reponav-item" data-selected-links="repo_settings repo_branch_settings hooks /cterraza/ServoController/settings">
      <span class="octicon octicon-gear"></span>
      Settings
</a>
</nav>

  </div>
</div>

<div class="container repo-container new-discussion-timeline experiment-repo-nav">
  <div class="repository-content">

    

<a href="/cterraza/ServoController/blob/2665df48ca8a1b0abdaaaa48b20f77988e90e00d/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:c997b4393e8cbd003cd5836f1e3e49d0 -->

  <div class="file-navigation js-zeroclipboard-container">
    
<div class="select-menu js-menu-container js-select-menu left">
  <button class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    title="master"
    type="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <i>Branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </button>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
        <span class="select-menu-title">Switch branches/tags</span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Find or create a branch…" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Find or create a branch…">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Find or create a branch…" class="js-select-menu-tab" role="tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab" role="tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches" role="menu">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/cterraza/ServoController/blob/master/README.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/branches" class="js-create-branch select-menu-item select-menu-new-item-form js-navigation-item js-new-item-form" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="/HJqh5YXk6aDLoYvHj81p23aje8bmvQPag0G3PR2Cypx/LIQhwHKjOmr9iSbUlRi5W8DrtvOs3BIRPxp4NRO6g==" /></div>
            <span class="octicon octicon-git-branch select-menu-item-icon"></span>
            <div class="select-menu-item-text">
              <span class="select-menu-item-heading">Create branch: <span class="js-new-item-name"></span></span>
              <span class="description">from ‘master’</span>
            </div>
            <input type="hidden" name="name" id="name" class="js-new-item-value">
            <input type="hidden" name="branch" id="branch" value="master">
            <input type="hidden" name="path" id="path" value="README.md">
</form>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

    <div class="btn-group right">
      <a href="/cterraza/ServoController/find/master"
            class="js-show-file-finder btn btn-sm"
            data-pjax
            data-hotkey="t">
        Find file
      </a>
      <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button">Copy path</button>
    </div>
    <div class="breadcrumb js-zeroclipboard-target">
      <span class="repo-root js-repo-root"><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/cterraza/ServoController" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">ServoController</span></a></span></span><span class="separator">/</span><strong class="final-path">README.md</strong>
    </div>
  </div>


  <div class="commit-tease">
      <span class="right">
        <a class="commit-tease-sha" href="/cterraza/ServoController/commit/2665df48ca8a1b0abdaaaa48b20f77988e90e00d" data-pjax>
          2665df4
        </a>
        <time datetime="2015-11-29T17:07:24Z" is="relative-time">Nov 29, 2015</time>
      </span>
      <div>
        <img alt="@cterraza" class="avatar" height="20" src="https://avatars0.githubusercontent.com/u/10850282?v=3&amp;s=40" width="20" />
        <a href="/cterraza" class="user-mention" rel="author">cterraza</a>
          <a href="/cterraza/ServoController/commit/2665df48ca8a1b0abdaaaa48b20f77988e90e00d" class="message" data-pjax="true" title="Update README.md">Update README.md</a>
      </div>

    <div class="commit-tease-contributors">
      <a class="muted-link contributors-toggle" href="#blob_contributors_box" rel="facebox">
        <strong>1</strong>
         contributor
      </a>
      
    </div>

    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header" data-facebox-id="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list" data-facebox-id="facebox-description">
          <li class="facebox-user-list-item">
            <img alt="@cterraza" height="24" src="https://avatars2.githubusercontent.com/u/10850282?v=3&amp;s=48" width="24" />
            <a href="/cterraza">cterraza</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
  <div class="file-actions">

    <div class="btn-group">
      <a href="/cterraza/ServoController/raw/master/README.md" class="btn btn-sm " id="raw-url">Raw</a>
        <a href="/cterraza/ServoController/blame/master/README.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
      <a href="/cterraza/ServoController/commits/master/README.md" class="btn btn-sm " rel="nofollow">History</a>
    </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/cterraza/ServoController?branch=master&amp;filepath=README.md"
           aria-label="Open this file in GitHub Desktop"
           data-ga-click="Repository, open with desktop, type:windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/edit/master/README.md" class="inline-form js-update-url-with-hash" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="BwyIVQlcg3JqM+GPzal0CAxaJ7rEy2uDYcNgNjVVLOiRaASJ0Htd5Ip/G7jopDOPERgl8te+ZJ7A0cl8OV4ylA==" /></div>
          <button class="octicon-btn tooltipped tooltipped-nw" type="submit"
            aria-label="Edit this file" data-hotkey="e" data-disable-with>
            <span class="octicon octicon-pencil"></span>
          </button>
</form>        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/cterraza/ServoController/delete/master/README.md" class="inline-form" data-form-nonce="fc40be865cb61b3c17580c5788ae02d822d379a0" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="9Z84foq+4rgBB3TXjwM8oTioYJVL7L+EhOtRMrsrZUxyGZuplodEr4jPYPtktAXJq12cwZURmuaRQb8urbLWwg==" /></div>
          <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-nw" type="submit"
            aria-label="Delete this file" data-disable-with>
            <span class="octicon octicon-trashcan"></span>
          </button>
</form>  </div>

  <div class="file-info">
      17 lines (9 sloc)
      <span class="file-info-divider"></span>
    614 Bytes
  </div>
</div>

  
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-servocontroller" class="anchor" href="#servocontroller" aria-hidden="true"><span class="octicon octicon-link"></span></a>ServoController</h1>

<p>Firmware y software para control de servos hasta 18 canales con atmega328</p>
=======
# ServoController
Firmware y software para control de servos hasta 18 canales con atmega328
>>>>>>> origin/master

<p>Arduino HD Servocontroller </p>

<p>Este repositorio ha sido creado con el fin de continuar con el desarrollo del firmware y software para windows de una controladora
de servos de forma serial haciendo uso de un arduino y su conexión USB-SERIAL</p>

<p>ArduinoServocontroller, contiene el software de PC compatible con Visual Studio 2013 en adelante</p>

<<<<<<< HEAD
<p>HDservocontroller, codigo para arduino uno o nano/p&gt;

</p><p>Ejecutable, incluye un .EXE con la última versión generada del software de PC</p>

<p>Gracias.</p>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="" class="js-jump-to-line-form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" aria-label="Jump to line" autofocus>
    <button type="submit" class="btn">Go</button>
</form></div>

  </div>
  <div class="modal-backdrop"></div>
</div>

    </div>
  </div>

    </div>

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>
        <li><a href="https://github.com/pricing" data-ga-click="Footer, go to pricing, text:pricing">Pricing</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.06311s from github-fe129-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
        <li><a href="https://help.github.com" data-ga-click="Footer, go to help, text:help">Help</a></li>
    </ul>
  </div>
</div>



    
    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <button type="button" class="flash-close js-flash-close js-ajax-error-dismiss" aria-label="Dismiss error">
        <span class="octicon octicon-x"></span>
      </button>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" integrity="sha256-fRgMK7V3nst6tdBM6K+ZnnODbc8N8ajES2nGKh3gcy8=" src="https://assets-cdn.github.com/assets/frameworks-7d180c2bb5779ecb7ab5d04ce8af999e73836dcf0df1a8c44b69c62a1de0732f.js"></script>
      <script async="async" crossorigin="anonymous" integrity="sha256-BDAUbaSVMjhV4vOS1TWUkOCuu9dWJZmtOX7J3treTg4=" src="https://assets-cdn.github.com/assets/github-0430146da495323855e2f392d5359490e0aebbd7562599ad397ec9dedade4e0e.js"></script>
      
      
    <div class="js-stale-session-flash stale-session-flash flash flash-warn flash-banner hidden">
      <span class="octicon octicon-alert"></span>
      <span class="signed-in-tab-flash">You signed in with another tab or window. <a href="">Reload</a> to refresh your session.</span>
      <span class="signed-out-tab-flash">You signed out in another tab or window. <a href="">Reload</a> to refresh your session.</span>
    </div>
  </body>
</html>

=======
<p>HDservocontroller, codigo para arduino uno o nano/p>

<p>Ejecutable, incluye un .EXE con la última versión generada del software de PC</p>


<p>Gracias.</p>
>>>>>>> origin/master
