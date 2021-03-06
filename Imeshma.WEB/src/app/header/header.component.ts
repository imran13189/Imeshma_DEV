import { Component, OnInit } from '@angular/core';
import * as $ from "jquery";
import { AuthService, FacebookLoginProvider, GoogleLoginProvider, LinkedinLoginProvider } from 'angular-6-social-login';
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private socialAuthService: AuthService) { }
  public socialSignIn(socialPlatform: string) {
    let socialPlatformProvider;
    if (socialPlatform == "facebook") {
      socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    } else if (socialPlatform == "google") {
      socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
    } else if (socialPlatform == "linkedin") {
      socialPlatformProvider = LinkedinLoginProvider.PROVIDER_ID;
    }

    this.socialAuthService.signIn(socialPlatformProvider).then(
      (userData) => {
        debugger;
        console.log(socialPlatform + " sign in data : ", userData);
        // Now sign-in with userData
        // ...
        
      }
    );
  }



  ngOnInit() {
    var e = $;
    e.fn.classyNav = function (n) {
      var a = e(".classy-nav-container"),
        s = e(".classynav ul"),
        o = e(".classynav > ul > li"),
        l = e(".classy-navbar-toggler"),
        i = e(".classycloseIcon"),
        t = e(".navbarToggler"),
        d = e(".classy-menu"),
        r = e(window),
        c = e.extend({
          theme: "light",
          breakpoint: 991,
          openCloseSpeed: 300,
          alwaysHidden: !1,
          openMobileMenu: "left",
          dropdownRtl: !1,
          stickyNav: !1,
          stickyFooterNav: !1
        }, n);
      return this.each(function () {
        function n() {
          window.innerWidth <= c.breakpoint ? a.removeClass("breakpoint-off").addClass("breakpoint-on") : a.removeClass("breakpoint-on").addClass("breakpoint-off")
        }
        "light" !== c.theme && "dark" !== c.theme || a.addClass(c.theme), "left" !== c.openMobileMenu && "right" !== c.openMobileMenu || a.addClass(c.openMobileMenu), !0 === c.dropdownRtl && a.addClass("dropdown-rtl"), l.on("click", function () {
          t.toggleClass("active"), d.toggleClass("menu-on")
        }), i.on("click", function () {
          d.removeClass("menu-on"), t.removeClass("active")
        }), o.has(".dropdown").addClass("cn-dropdown-item"), o.has(".megamenu").addClass("megamenu-item"), s.find("li a").each(function () {
          e(this).next().length > 0 && (e(this).parent("li").addClass("has-down").append('<span class="dd-trigger"></span>'), e(this).parent("li").addClass("has-down").append('<span class="dd-arrow"></span>'))
        }), s.find("li .dd-trigger").on("click", function (n) {
          n.preventDefault(), e(this).parent("li").children("ul").stop(!0, !0).slideToggle(c.openCloseSpeed), e(this).parent("li").toggleClass("active")
        }), e(".megamenu-item, .cn-dropdown-item").addClass("pr12"), e(".megamenu-item").removeClass("has-down pr12"), s.find("li .dd-trigger").on("click", function (n) {
          n.preventDefault(), e(this).parent("li").children(".megamenu").slideToggle(c.openCloseSpeed)
        }), n(), r.on("resize", function () {
          n()
        }), !0 === c.alwaysHidden && a.addClass("breakpoint-on").removeClass("breakpoint-off"), !0 === c.stickyNav && r.on("scroll", function () {
          r.scrollTop() > 0 ? a.addClass("classy-sticky") : a.removeClass("classy-sticky")
        }), !0 === c.stickyFooterNav && a.addClass("classy-sticky-footer")
      })
    }

    $('#essenceNav').classyNav();

  }

}
