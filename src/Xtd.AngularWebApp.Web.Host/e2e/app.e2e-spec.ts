import { AngularWebAppTemplatePage } from './app.po';

describe('AngularWebApp App', function() {
  let page: AngularWebAppTemplatePage;

  beforeEach(() => {
    page = new AngularWebAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
